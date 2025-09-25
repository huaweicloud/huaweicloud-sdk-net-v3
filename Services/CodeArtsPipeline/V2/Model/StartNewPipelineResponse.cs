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
    public class StartNewPipelineResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 流水线ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线执行ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartNewPipelineResponse {\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  buildId: ").Append(BuildId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartNewPipelineResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartNewPipelineResponse input)
        {
            if (input == null) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.BuildId != input.BuildId || (this.BuildId != null && !this.BuildId.Equals(input.BuildId))) return false;

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
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.BuildId != null) hashCode = hashCode * 59 + this.BuildId.GetHashCode();
                return hashCode;
            }
        }
    }
}
