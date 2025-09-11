using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MaskRuleRequest 
    {

        /// <summary>
        /// 匹配正则
        /// </summary>
        [JsonProperty("mask_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskRegex { get; set; }

        /// <summary>
        /// 脱敏值
        /// </summary>
        [JsonProperty("mask_value", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskValue { get; set; }

        /// <summary>
        /// 隐私数据保护规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskRuleRequest {\n");
            sb.Append("  maskRegex: ").Append(MaskRegex).Append("\n");
            sb.Append("  maskValue: ").Append(MaskValue).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MaskRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MaskRuleRequest input)
        {
            if (input == null) return false;
            if (this.MaskRegex != input.MaskRegex || (this.MaskRegex != null && !this.MaskRegex.Equals(input.MaskRegex))) return false;
            if (this.MaskValue != input.MaskValue || (this.MaskValue != null && !this.MaskValue.Equals(input.MaskValue))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;

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
                if (this.MaskRegex != null) hashCode = hashCode * 59 + this.MaskRegex.GetHashCode();
                if (this.MaskValue != null) hashCode = hashCode * 59 + this.MaskValue.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
