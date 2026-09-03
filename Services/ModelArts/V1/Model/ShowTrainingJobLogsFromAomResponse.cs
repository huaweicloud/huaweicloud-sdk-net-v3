using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTrainingJobLogsFromAomResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：返回日志的起始行号。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("start_line", NullValueHandling = NullValueHandling.Ignore)]
        public string StartLine { get; set; }

        /// <summary>
        /// **参数解释**：返回日志的结束行号。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("end_line", NullValueHandling = NullValueHandling.Ignore)]
        public string EndLine { get; set; }

        /// <summary>
        /// **参数解释**：返回的日志行数。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lines { get; set; }

        /// <summary>
        /// **参数解释**：日志内容。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingJobLogsFromAomResponse {\n");
            sb.Append("  startLine: ").Append(StartLine).Append("\n");
            sb.Append("  endLine: ").Append(EndLine).Append("\n");
            sb.Append("  lines: ").Append(Lines).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingJobLogsFromAomResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingJobLogsFromAomResponse input)
        {
            if (input == null) return false;
            if (this.StartLine != input.StartLine || (this.StartLine != null && !this.StartLine.Equals(input.StartLine))) return false;
            if (this.EndLine != input.EndLine || (this.EndLine != null && !this.EndLine.Equals(input.EndLine))) return false;
            if (this.Lines != input.Lines || (this.Lines != null && !this.Lines.Equals(input.Lines))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;

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
                if (this.StartLine != null) hashCode = hashCode * 59 + this.StartLine.GetHashCode();
                if (this.EndLine != null) hashCode = hashCode * 59 + this.EndLine.GetHashCode();
                if (this.Lines != null) hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
