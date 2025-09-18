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
    public class RuleSetV2 
    {

        /// <summary>
        /// 规则集id，需要从web界面获取
        /// </summary>
        [JsonProperty("ruleset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RulesetId { get; set; }

        /// <summary>
        /// 检查语言，支持cpp,java,js,python,php,css,html,go,typescript
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleSetV2 {\n");
            sb.Append("  rulesetId: ").Append(RulesetId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleSetV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleSetV2 input)
        {
            if (input == null) return false;
            if (this.RulesetId != input.RulesetId || (this.RulesetId != null && !this.RulesetId.Equals(input.RulesetId))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;

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
                if (this.RulesetId != null) hashCode = hashCode * 59 + this.RulesetId.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
