using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// **参数解释：** E2E公共设置信息。
    /// </summary>
    public class E2ePolicyDto 
    {

        /// <summary>
        /// **参数解释：** 是否开启单号自动提取。 **取值范围：** true：开启单号自动提取，false：未开启单号自动提取。
        /// </summary>
        [JsonProperty("auto_extract", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExtract { get; set; }

        /// <summary>
        /// **参数解释：** 自动提取时的单号前缀合集，英文逗号分隔。 **取值范围：** 单个前缀长度最多200个字符，最多允许配置10个前缀。
        /// </summary>
        [JsonProperty("prefix_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string PrefixSymbol { get; set; }

        /// <summary>
        /// **参数解释：** 自动提取时的分隔符。
        /// </summary>
        [JsonProperty("separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        /// <summary>
        /// **参数解释：** 自动提取时的单号后缀。
        /// </summary>
        [JsonProperty("suffix_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string SuffixSymbol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class E2ePolicyDto {\n");
            sb.Append("  autoExtract: ").Append(AutoExtract).Append("\n");
            sb.Append("  prefixSymbol: ").Append(PrefixSymbol).Append("\n");
            sb.Append("  separator: ").Append(Separator).Append("\n");
            sb.Append("  suffixSymbol: ").Append(SuffixSymbol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as E2ePolicyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(E2ePolicyDto input)
        {
            if (input == null) return false;
            if (this.AutoExtract != input.AutoExtract || (this.AutoExtract != null && !this.AutoExtract.Equals(input.AutoExtract))) return false;
            if (this.PrefixSymbol != input.PrefixSymbol || (this.PrefixSymbol != null && !this.PrefixSymbol.Equals(input.PrefixSymbol))) return false;
            if (this.Separator != input.Separator || (this.Separator != null && !this.Separator.Equals(input.Separator))) return false;
            if (this.SuffixSymbol != input.SuffixSymbol || (this.SuffixSymbol != null && !this.SuffixSymbol.Equals(input.SuffixSymbol))) return false;

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
                if (this.AutoExtract != null) hashCode = hashCode * 59 + this.AutoExtract.GetHashCode();
                if (this.PrefixSymbol != null) hashCode = hashCode * 59 + this.PrefixSymbol.GetHashCode();
                if (this.Separator != null) hashCode = hashCode * 59 + this.Separator.GetHashCode();
                if (this.SuffixSymbol != null) hashCode = hashCode * 59 + this.SuffixSymbol.GetHashCode();
                return hashCode;
            }
        }
    }
}
