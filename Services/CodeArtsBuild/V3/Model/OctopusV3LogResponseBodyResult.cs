using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class OctopusV3LogResponseBodyResult 
    {

        /// <summary>
        /// **参数解释**： 是否还有剩余日志标识。 **约束限制**： 不涉及。 **取值范围**： true或false。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("has_more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// **参数解释**： 日志查询起始偏移量。 **约束限制**： 不涉及。 **取值范围**： 数字组成。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string StartOffset { get; set; }

        /// <summary>
        /// **参数解释**： 日志查询结束偏移量。 **约束限制**： 不涉及。 **取值范围**： 数字组成。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string EndOffset { get; set; }

        /// <summary>
        /// **参数解释**： 返回日志内容，可能会空，请再次请求。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("log", NullValueHandling = NullValueHandling.Ignore)]
        public string Log { get; set; }

        /// <summary>
        /// **参数解释**： 日志来源。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OctopusV3LogResponseBodyResult {\n");
            sb.Append("  hasMore: ").Append(HasMore).Append("\n");
            sb.Append("  startOffset: ").Append(StartOffset).Append("\n");
            sb.Append("  endOffset: ").Append(EndOffset).Append("\n");
            sb.Append("  log: ").Append(Log).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OctopusV3LogResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OctopusV3LogResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.HasMore != input.HasMore || (this.HasMore != null && !this.HasMore.Equals(input.HasMore))) return false;
            if (this.StartOffset != input.StartOffset || (this.StartOffset != null && !this.StartOffset.Equals(input.StartOffset))) return false;
            if (this.EndOffset != input.EndOffset || (this.EndOffset != null && !this.EndOffset.Equals(input.EndOffset))) return false;
            if (this.Log != input.Log || (this.Log != null && !this.Log.Equals(input.Log))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;

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
                if (this.HasMore != null) hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.StartOffset != null) hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                if (this.EndOffset != null) hashCode = hashCode * 59 + this.EndOffset.GetHashCode();
                if (this.Log != null) hashCode = hashCode * 59 + this.Log.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
