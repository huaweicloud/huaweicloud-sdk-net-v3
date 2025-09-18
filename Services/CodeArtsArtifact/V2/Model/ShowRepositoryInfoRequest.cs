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
    /// Request Object
    /// </summary>
    public class ShowRepositoryInfoRequest 
    {

        /// <summary>
        /// 仓库id
        /// </summary>
        [SDKProperty("repo_id", IsPath = true)]
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryInfoRequest {\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryInfoRequest input)
        {
            if (input == null) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;

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
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                return hashCode;
            }
        }
    }
}
