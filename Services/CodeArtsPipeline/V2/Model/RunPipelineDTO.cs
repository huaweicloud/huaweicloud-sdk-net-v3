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
    /// 运行流水线请求体
    /// </summary>
    public class RunPipelineDTO 
    {

        /// <summary>
        /// **参数解释**： 代码源信息列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<RunPipelineDTOSources> Sources { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行描述。 **约束限制**： 不涉及。 **取值范围**： 不超过1024字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 使用的自定义参数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<RunPipelineDTOVariables> Variables { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行时选择的流水线任务。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("choose_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChooseJobs { get; set; }

        /// <summary>
        /// **参数解释**： 选择的流水线阶段。优先级高于choose_jobs，即stage未选择时，无视choose_jobs中该stage下的job。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("choose_stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChooseStages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunPipelineDTO {\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("  chooseJobs: ").Append(ChooseJobs).Append("\n");
            sb.Append("  chooseStages: ").Append(ChooseStages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunPipelineDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunPipelineDTO input)
        {
            if (input == null) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;
            if (this.ChooseJobs != input.ChooseJobs || (this.ChooseJobs != null && input.ChooseJobs != null && !this.ChooseJobs.SequenceEqual(input.ChooseJobs))) return false;
            if (this.ChooseStages != input.ChooseStages || (this.ChooseStages != null && input.ChooseStages != null && !this.ChooseStages.SequenceEqual(input.ChooseStages))) return false;

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
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.ChooseJobs != null) hashCode = hashCode * 59 + this.ChooseJobs.GetHashCode();
                if (this.ChooseStages != null) hashCode = hashCode * 59 + this.ChooseStages.GetHashCode();
                return hashCode;
            }
        }
    }
}
