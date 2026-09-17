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
    public class CreateVariableGroupResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 参数组ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("pipeline_variable_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineVariableGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVariableGroupResponse {\n");
            sb.Append("  pipelineVariableGroupId: ").Append(PipelineVariableGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVariableGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVariableGroupResponse input)
        {
            if (input == null) return false;
            if (this.PipelineVariableGroupId != input.PipelineVariableGroupId || (this.PipelineVariableGroupId != null && !this.PipelineVariableGroupId.Equals(input.PipelineVariableGroupId))) return false;

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
                if (this.PipelineVariableGroupId != null) hashCode = hashCode * 59 + this.PipelineVariableGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
