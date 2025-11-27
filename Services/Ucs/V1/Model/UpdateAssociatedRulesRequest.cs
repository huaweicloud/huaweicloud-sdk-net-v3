using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAssociatedRulesRequest 
    {

        /// <summary>
        /// 权限策略id以及涉及到的命名空间
        /// </summary>
        [JsonProperty("ruleIDNamespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleIDNamespaces> RuleIDNamespaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAssociatedRulesRequest {\n");
            sb.Append("  ruleIDNamespaces: ").Append(RuleIDNamespaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAssociatedRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAssociatedRulesRequest input)
        {
            if (input == null) return false;
            if (this.RuleIDNamespaces != input.RuleIDNamespaces || (this.RuleIDNamespaces != null && input.RuleIDNamespaces != null && !this.RuleIDNamespaces.SequenceEqual(input.RuleIDNamespaces))) return false;

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
                if (this.RuleIDNamespaces != null) hashCode = hashCode * 59 + this.RuleIDNamespaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
