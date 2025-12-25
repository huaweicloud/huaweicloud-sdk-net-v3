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
    public class CreateArtifactoryResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("artifactory", NullValueHandling = NullValueHandling.Ignore)]
        public RepositoryDO Artifactory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateArtifactoryResult {\n");
            sb.Append("  artifactory: ").Append(Artifactory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateArtifactoryResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateArtifactoryResult input)
        {
            if (input == null) return false;
            if (this.Artifactory != input.Artifactory || (this.Artifactory != null && !this.Artifactory.Equals(input.Artifactory))) return false;

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
                if (this.Artifactory != null) hashCode = hashCode * 59 + this.Artifactory.GetHashCode();
                return hashCode;
            }
        }
    }
}
