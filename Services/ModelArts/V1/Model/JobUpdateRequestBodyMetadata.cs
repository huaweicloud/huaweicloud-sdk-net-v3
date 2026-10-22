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
    /// **参数解释**：训练作业元信息。 **约束限制**：不涉及。
    /// </summary>
    public class JobUpdateRequestBodyMetadata 
    {

        /// <summary>
        /// **参数解释**：训练作业高级功能配置。可选取值如下：   - \&quot;jupyter-lab/enable\&quot;: \&quot;true\&quot;（JupyterLab训练应用程序） **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("annotation", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobUpdateRequestBodyMetadata {\n");
            sb.Append("  annotation: ").Append(Annotation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobUpdateRequestBodyMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobUpdateRequestBodyMetadata input)
        {
            if (input == null) return false;
            if (this.Annotation != input.Annotation || (this.Annotation != null && input.Annotation != null && !this.Annotation.SequenceEqual(input.Annotation))) return false;

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
                if (this.Annotation != null) hashCode = hashCode * 59 + this.Annotation.GetHashCode();
                return hashCode;
            }
        }
    }
}
