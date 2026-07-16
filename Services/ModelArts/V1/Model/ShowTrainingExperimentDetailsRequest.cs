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
    /// Request Object
    /// </summary>
    public class ShowTrainingExperimentDetailsRequest 
    {

        /// <summary>
        /// **参数解释**：实验ID。创建训练实验时自动生成返回。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("experiment_id", IsPath = true)]
        [JsonProperty("experiment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperimentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingExperimentDetailsRequest {\n");
            sb.Append("  experimentId: ").Append(ExperimentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingExperimentDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingExperimentDetailsRequest input)
        {
            if (input == null) return false;
            if (this.ExperimentId != input.ExperimentId || (this.ExperimentId != null && !this.ExperimentId.Equals(input.ExperimentId))) return false;

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
                if (this.ExperimentId != null) hashCode = hashCode * 59 + this.ExperimentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
