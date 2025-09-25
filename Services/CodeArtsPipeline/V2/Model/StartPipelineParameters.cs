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
    /// 
    /// </summary>
    public class StartPipelineParameters 
    {

        /// <summary>
        /// **参数解释**： 启动流水线时的构建参数。 **约束限制**： 不涉及。 **取值范围**： 不超过8192个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("build_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<StartPipelineBuildParams> BuildParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartPipelineParameters {\n");
            sb.Append("  buildParams: ").Append(BuildParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartPipelineParameters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartPipelineParameters input)
        {
            if (input == null) return false;
            if (this.BuildParams != input.BuildParams || (this.BuildParams != null && input.BuildParams != null && !this.BuildParams.SequenceEqual(input.BuildParams))) return false;

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
                if (this.BuildParams != null) hashCode = hashCode * 59 + this.BuildParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
