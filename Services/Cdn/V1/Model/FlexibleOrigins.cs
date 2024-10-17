using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 灵活回源信息,最多20条。
    /// </summary>
    public class FlexibleOrigins 
    {

        /// <summary>
        /// URI的匹配方式，支持文件后缀（file_extension）和路径前缀（file_path）。
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// file_extension（文件后缀）： 支持所有格式的文件类型。 输入首字符为“.”，以“;”进行分隔。 输入的文件后缀名总数不能超过20个。 file_path（目录路径）：输入要求以“/”作为首字符，以“;”进行分隔，输入的目录路径总数不能超过20个。
        /// </summary>
        [JsonProperty("match_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchPattern { get; set; }

        /// <summary>
        /// 优先级取值范围为1~100，数值越大优先级越高。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 回源信息。  &gt; 每个目录的回源源站数量不超过1个。
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
