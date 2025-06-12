using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 互动规则库信息
    /// </summary>
    public class InteractionRuleGroup 
    {

        /// <summary>
        /// 互动规则库名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 互动规则列表
        /// </summary>
        [JsonProperty("interaction_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<InteractionRuleInfo> InteractionRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionRuleGroup {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  interactionRules: ").Append(InteractionRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InteractionRuleGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InteractionRuleGroup input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.InteractionRules != input.InteractionRules || (this.InteractionRules != null && input.InteractionRules != null && !this.InteractionRules.SequenceEqual(input.InteractionRules))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.InteractionRules != null) hashCode = hashCode * 59 + this.InteractionRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
