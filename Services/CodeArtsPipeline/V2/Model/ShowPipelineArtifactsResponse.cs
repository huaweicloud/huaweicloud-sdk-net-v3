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
    public class ShowPipelineArtifactsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 流水线任务产物列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("artifacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Artifact> Artifacts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineArtifactsResponse {\n");
            sb.Append("  artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineArtifactsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineArtifactsResponse input)
        {
            if (input == null) return false;
            if (this.Artifacts != input.Artifacts || (this.Artifacts != null && input.Artifacts != null && !this.Artifacts.SequenceEqual(input.Artifacts))) return false;

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
                if (this.Artifacts != null) hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
                return hashCode;
            }
        }
    }
}
