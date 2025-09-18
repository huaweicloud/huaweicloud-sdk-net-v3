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
    public class IDERepoRevisionModel 
    {

        /// <summary>
        /// 仓库id集合
        /// </summary>
        [JsonProperty("repository_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryIds { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IDERepoRevisionModel {\n");
            sb.Append("  repositoryIds: ").Append(RepositoryIds).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IDERepoRevisionModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IDERepoRevisionModel input)
        {
            if (input == null) return false;
            if (this.RepositoryIds != input.RepositoryIds || (this.RepositoryIds != null && !this.RepositoryIds.Equals(input.RepositoryIds))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;

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
                if (this.RepositoryIds != null) hashCode = hashCode * 59 + this.RepositoryIds.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }
    }
}
