using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchArtifactsResult 
    {

        /// <summary>
        /// **参数解释**： 文件列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("artifacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ArtifactSearchResult> Artifacts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchArtifactsResult {\n");
            sb.Append("  artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchArtifactsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchArtifactsResult input)
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
