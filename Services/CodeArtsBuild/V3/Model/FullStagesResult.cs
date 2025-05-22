using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class FullStagesResult 
    {

        /// <summary>
        /// 构建步骤
        /// </summary>
        [JsonProperty("build_stages", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, BuildStageRecord> BuildStages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullStagesResult {\n");
            sb.Append("  buildStages: ").Append(BuildStages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullStagesResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullStagesResult input)
        {
            if (input == null) return false;
            if (this.BuildStages != input.BuildStages || (this.BuildStages != null && input.BuildStages != null && !this.BuildStages.SequenceEqual(input.BuildStages))) return false;

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
                if (this.BuildStages != null) hashCode = hashCode * 59 + this.BuildStages.GetHashCode();
                return hashCode;
            }
        }
    }
}
