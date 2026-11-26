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
    /// **参数解释：** 高级回源，实现根据不同的资源类型或路径回源到不同源站 **约束限制：** 最多配置20条
    /// </summary>
    public class FlexibleOrigins 
    {

        /// <summary>
        /// **参数解释：** URI的匹配方式 **约束限制：** 不涉及 **取值范围：** - file_extension: 文件后缀匹配 - file_path: 目录路径 - all: 匹配所有文件  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// **参数解释：** URI的匹配规则 **约束限制：** match_type为file_extension时：   - 支持所有格式的文件类型   - 输入首字符为“.”，以“;”进行分隔   - 输入的文件后缀名总数不能超过20个  match_type为file_path时：   - 要求以“/”作为首字符   - 以“;”进行分隔   - 输入的目录路径总数不能超过20个  match_type为all时：置空  &gt; 文件名后缀英文字符大、小写代表不同资源  **取值范围：** 1-512个字符 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("match_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchPattern { get; set; }

        /// <summary>
        /// **参数解释：** 优先级 &gt; 数值越大优先级越高  **约束限制：** 不涉及 **取值范围：** 1-1000 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释：** 配置客户端请求匹配当前规则时，CDN节点回源访问的源站 **约束限制：** 每条规则的回源源站数量不超过1个 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("back_sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackSources> BackSources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexibleOrigins {\n");
            sb.Append("  matchType: ").Append(MatchType).Append("\n");
            sb.Append("  matchPattern: ").Append(MatchPattern).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  backSources: ").Append(BackSources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlexibleOrigins);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlexibleOrigins input)
        {
            if (input == null) return false;
            if (this.MatchType != input.MatchType || (this.MatchType != null && !this.MatchType.Equals(input.MatchType))) return false;
            if (this.MatchPattern != input.MatchPattern || (this.MatchPattern != null && !this.MatchPattern.Equals(input.MatchPattern))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.BackSources != input.BackSources || (this.BackSources != null && input.BackSources != null && !this.BackSources.SequenceEqual(input.BackSources))) return false;

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
                if (this.MatchType != null) hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.MatchPattern != null) hashCode = hashCode * 59 + this.MatchPattern.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.BackSources != null) hashCode = hashCode * 59 + this.BackSources.GetHashCode();
                return hashCode;
            }
        }
    }
}
