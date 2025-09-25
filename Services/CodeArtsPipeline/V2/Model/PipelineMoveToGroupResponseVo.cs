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
    /// **参数解释**： 响应详情。 **取值范围**： 不涉及。 
    /// </summary>
    public class PipelineMoveToGroupResponseVo 
    {

        /// <summary>
        /// **参数解释**： 响应码。 **取值范围**： - failed：失败。 - success：成功。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 流水线ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineMoveToGroupResponseVo {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineName: ").Append(PipelineName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineMoveToGroupResponseVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineMoveToGroupResponseVo input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineName != input.PipelineName || (this.PipelineName != null && !this.PipelineName.Equals(input.PipelineName))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.PipelineName != null) hashCode = hashCode * 59 + this.PipelineName.GetHashCode();
                return hashCode;
            }
        }
    }
}
