using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RuleSelector 
    {

        /// <summary>
        /// 匹配类型，目前只支持doublestar
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// 选择器匹配类型,当前支持repoMatches
        /// </summary>
        [JsonProperty("decoration", NullValueHandling = NullValueHandling.Ignore)]
        public string Decoration { get; set; }

        /// <summary>
        /// 选择器匹配样式，最大长度512。支持正则表达式，正则表达式规则可填写如 nginx-* ，{repo1，repo2} 等，其中： * ： 匹配不包含 &#39;/&#39; 的任何字段。 **：匹配包含 &#39;/&#39; 的任何字段。 ? ：匹配任何单个非 &#39;/&#39; 的字符。 {选项1,选项2,...}：同时匹配多个选项。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        [JsonProperty("extras", NullValueHandling = NullValueHandling.Ignore)]
        public string Extras { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleSelector {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  decoration: ").Append(Decoration).Append("\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  extras: ").Append(Extras).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleSelector);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleSelector input)
        {
            if (input == null) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Decoration != input.Decoration || (this.Decoration != null && !this.Decoration.Equals(input.Decoration))) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.Extras != input.Extras || (this.Extras != null && !this.Extras.Equals(input.Extras))) return false;

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
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Decoration != null) hashCode = hashCode * 59 + this.Decoration.GetHashCode();
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.Extras != null) hashCode = hashCode * 59 + this.Extras.GetHashCode();
                return hashCode;
            }
        }
    }
}
