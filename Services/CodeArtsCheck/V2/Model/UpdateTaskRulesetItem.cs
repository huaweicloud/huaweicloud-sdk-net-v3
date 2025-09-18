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
    public class UpdateTaskRulesetItem 
    {

        /// <summary>
        /// 规则集语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 规则集ID,通过调用ListTaskRuleset接口，根据响应参数中的template_id获得
        /// </summary>
        [JsonProperty("rule_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// 任务语言和规则集的关系是否启用，1是启用，0是未启用
        /// </summary>
        [JsonProperty("if_use", NullValueHandling = NullValueHandling.Ignore)]
        public string IfUse { get; set; }

        /// <summary>
        /// 新/老数据表示，默认1
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTaskRulesetItem {\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  ruleSetId: ").Append(RuleSetId).Append("\n");
            sb.Append("  ifUse: ").Append(IfUse).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTaskRulesetItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTaskRulesetItem input)
        {
            if (input == null) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.RuleSetId != input.RuleSetId || (this.RuleSetId != null && !this.RuleSetId.Equals(input.RuleSetId))) return false;
            if (this.IfUse != input.IfUse || (this.IfUse != null && !this.IfUse.Equals(input.IfUse))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RuleSetId != null) hashCode = hashCode * 59 + this.RuleSetId.GetHashCode();
                if (this.IfUse != null) hashCode = hashCode * 59 + this.IfUse.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
