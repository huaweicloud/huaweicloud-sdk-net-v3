using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateRepoRequestBody 
    {

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 所在命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gitRepositorySpec", NullValueHandling = NullValueHandling.Ignore)]
        public GitRepositorySpec GitRepositorySpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secretInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SecretInfo SecretInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusterInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterInfo ClusterInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRepoRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  gitRepositorySpec: ").Append(GitRepositorySpec).Append("\n");
            sb.Append("  secretInfo: ").Append(SecretInfo).Append("\n");
            sb.Append("  clusterInfo: ").Append(ClusterInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRepoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRepoRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.GitRepositorySpec != input.GitRepositorySpec || (this.GitRepositorySpec != null && !this.GitRepositorySpec.Equals(input.GitRepositorySpec))) return false;
            if (this.SecretInfo != input.SecretInfo || (this.SecretInfo != null && !this.SecretInfo.Equals(input.SecretInfo))) return false;
            if (this.ClusterInfo != input.ClusterInfo || (this.ClusterInfo != null && !this.ClusterInfo.Equals(input.ClusterInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.GitRepositorySpec != null) hashCode = hashCode * 59 + this.GitRepositorySpec.GetHashCode();
                if (this.SecretInfo != null) hashCode = hashCode * 59 + this.SecretInfo.GetHashCode();
                if (this.ClusterInfo != null) hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
