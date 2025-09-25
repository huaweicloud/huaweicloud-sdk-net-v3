using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 流水线日志查询请求体。 **约束限制**： startOffset 和 endOffset 均设置为 0，则代表查询全量日志。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
    /// </summary>
    public class LogQuery 
    {

        /// <summary>
        /// **参数解释**： 日志起始偏移。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartOffset { get; set; }

        /// <summary>
        /// **参数解释**： 日志结束偏移。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndOffset { get; set; }

        /// <summary>
        /// **参数解释**： 最大日志行数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 排序规则。 **约束限制**： 不涉及。 **取值范围**： - asc：按排序字段升序。 - desc：按排序字段降序 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogQuery {\n");
            sb.Append("  startOffset: ").Append(StartOffset).Append("\n");
            sb.Append("  endOffset: ").Append(EndOffset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogQuery input)
        {
            if (input == null) return false;
            if (this.StartOffset != input.StartOffset || (this.StartOffset != null && !this.StartOffset.Equals(input.StartOffset))) return false;
            if (this.EndOffset != input.EndOffset || (this.EndOffset != null && !this.EndOffset.Equals(input.EndOffset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;

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
                if (this.StartOffset != null) hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                if (this.EndOffset != null) hashCode = hashCode * 59 + this.EndOffset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                return hashCode;
            }
        }
    }
}
