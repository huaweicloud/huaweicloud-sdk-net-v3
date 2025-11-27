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
    public class RuleIDNamespaces 
    {

        /// <summary>
        /// 权限策略id
        /// </summary>
        [JsonProperty("ruleIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RuleIDs { get; set; }

        /// <summary>
        /// 权限策略涉及到的命名空间
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Namespaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleIDNamespaces {\n");
            sb.Append("  ruleIDs: ").Append(RuleIDs).Append("\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleIDNamespaces);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleIDNamespaces input)
        {
            if (input == null) return false;
            if (this.RuleIDs != input.RuleIDs || (this.RuleIDs != null && input.RuleIDs != null && !this.RuleIDs.SequenceEqual(input.RuleIDs))) return false;
            if (this.Namespaces != input.Namespaces || (this.Namespaces != null && input.Namespaces != null && !this.Namespaces.SequenceEqual(input.Namespaces))) return false;

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
                if (this.RuleIDs != null) hashCode = hashCode * 59 + this.RuleIDs.GetHashCode();
                if (this.Namespaces != null) hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
