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
    public class GetScaleEvaluationsDevServerResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：规格容量保有情况 **约束限制**：不涉及 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("evaluations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerScaleEvaluation> Evaluations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetScaleEvaluationsDevServerResponse {\n");
            sb.Append("  evaluations: ").Append(Evaluations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetScaleEvaluationsDevServerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetScaleEvaluationsDevServerResponse input)
        {
            if (input == null) return false;
            if (this.Evaluations != input.Evaluations || (this.Evaluations != null && input.Evaluations != null && !this.Evaluations.SequenceEqual(input.Evaluations))) return false;

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
                if (this.Evaluations != null) hashCode = hashCode * 59 + this.Evaluations.GetHashCode();
                return hashCode;
            }
        }
    }
}
