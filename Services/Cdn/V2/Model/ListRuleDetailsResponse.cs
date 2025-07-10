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
    /// Response Object
    /// </summary>
    public class ListRuleDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleResponse> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRuleDetailsResponse {\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRuleDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRuleDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
