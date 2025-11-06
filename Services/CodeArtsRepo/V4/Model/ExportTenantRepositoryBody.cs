using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 仓库Id列表
    /// </summary>
    public class ExportTenantRepositoryBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repository_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> RepositoryIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportTenantRepositoryBody {\n");
            sb.Append("  repositoryIds: ").Append(RepositoryIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportTenantRepositoryBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportTenantRepositoryBody input)
        {
            if (input == null) return false;
            if (this.RepositoryIds != input.RepositoryIds || (this.RepositoryIds != null && input.RepositoryIds != null && !this.RepositoryIds.SequenceEqual(input.RepositoryIds))) return false;

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
                return hashCode;
            }
        }
    }
}
