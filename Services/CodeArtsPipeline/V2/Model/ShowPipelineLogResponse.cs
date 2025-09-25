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
    /// Response Object
    /// </summary>
    public class ShowPipelineLogResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 是否有更多日志。 **取值范围**： - true：有更多日志。 - false：没有更多日志。 
        /// </summary>
        [JsonProperty("has_more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// **参数解释**： 查询日志结束偏移。填入请求体end_offset字段，用于查询下一页日志。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string EndOffset { get; set; }

        /// <summary>
        /// **参数解释**： 查询日志起始偏移。填入请求体start_offset字段，用于查询下一页日志。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string StartOffset { get; set; }

        /// <summary>
        /// **参数解释**： 日志内容。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("log", NullValueHandling = NullValueHandling.Ignore)]
        public string Log { get; set; }

        /// <summary>
        /// **参数解释**： 所属步骤ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("step_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StepRunId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineLogResponse {\n");
            sb.Append("  hasMore: ").Append(HasMore).Append("\n");
            sb.Append("  endOffset: ").Append(EndOffset).Append("\n");
            sb.Append("  startOffset: ").Append(StartOffset).Append("\n");
            sb.Append("  log: ").Append(Log).Append("\n");
            sb.Append("  stepRunId: ").Append(StepRunId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineLogResponse input)
        {
            if (input == null) return false;
            if (this.HasMore != input.HasMore || (this.HasMore != null && !this.HasMore.Equals(input.HasMore))) return false;
            if (this.EndOffset != input.EndOffset || (this.EndOffset != null && !this.EndOffset.Equals(input.EndOffset))) return false;
            if (this.StartOffset != input.StartOffset || (this.StartOffset != null && !this.StartOffset.Equals(input.StartOffset))) return false;
            if (this.Log != input.Log || (this.Log != null && !this.Log.Equals(input.Log))) return false;
            if (this.StepRunId != input.StepRunId || (this.StepRunId != null && !this.StepRunId.Equals(input.StepRunId))) return false;

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
                if (this.EndOffset != null) hashCode = hashCode * 59 + this.EndOffset.GetHashCode();
                if (this.StartOffset != null) hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                if (this.Log != null) hashCode = hashCode * 59 + this.Log.GetHashCode();
                if (this.StepRunId != null) hashCode = hashCode * 59 + this.StepRunId.GetHashCode();
                return hashCode;
            }
        }
    }
}
