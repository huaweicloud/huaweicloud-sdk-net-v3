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
    /// Request Object
    /// </summary>
    public class ListRulesRequest 
    {

        /// <summary>
        /// 规则对应的语言
        /// </summary>
        [SDKProperty("rule_languages", IsQuery = true)]
        [JsonProperty("rule_languages", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleLanguages { get; set; }

        /// <summary>
        /// 缺陷等级，0致命，1严重，2一般，3提示
        /// </summary>
        [SDKProperty("rule_severity", IsQuery = true)]
        [JsonProperty("rule_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSeverity { get; set; }

        /// <summary>
        /// 分页索引，偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRulesRequest {\n");
            sb.Append("  ruleLanguages: ").Append(RuleLanguages).Append("\n");
            sb.Append("  ruleSeverity: ").Append(RuleSeverity).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRulesRequest input)
        {
            if (input == null) return false;
            if (this.RuleLanguages != input.RuleLanguages || (this.RuleLanguages != null && !this.RuleLanguages.Equals(input.RuleLanguages))) return false;
            if (this.RuleSeverity != input.RuleSeverity || (this.RuleSeverity != null && !this.RuleSeverity.Equals(input.RuleSeverity))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.RuleLanguages != null) hashCode = hashCode * 59 + this.RuleLanguages.GetHashCode();
                if (this.RuleSeverity != null) hashCode = hashCode * 59 + this.RuleSeverity.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
