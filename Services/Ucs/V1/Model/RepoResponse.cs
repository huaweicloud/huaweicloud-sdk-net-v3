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
    public class RepoResponse 
    {

        /// <summary>
        /// 仓库的唯一标识符
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 仓库类型，包括Bucket、HelmChart、GitRepository、HelmRepository，目前仅支持GitRepository
        /// </summary>
        [JsonProperty("repoType", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoType { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gitRepository", NullValueHandling = NullValueHandling.Ignore)]
        public GitRepository GitRepository { get; set; }

        /// <summary>
        /// 仓库状态，包括Health、Failed、Unknown、Progressing
        /// </summary>
        [JsonProperty("repoStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusterInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterInfo ClusterInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secretInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SecretInfo SecretInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoResponse {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  repoType: ").Append(RepoType).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  gitRepository: ").Append(GitRepository).Append("\n");
            sb.Append("  repoStatus: ").Append(RepoStatus).Append("\n");
            sb.Append("  clusterInfo: ").Append(ClusterInfo).Append("\n");
            sb.Append("  secretInfo: ").Append(SecretInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoResponse input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RepoType != input.RepoType || (this.RepoType != null && !this.RepoType.Equals(input.RepoType))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.GitRepository != input.GitRepository || (this.GitRepository != null && !this.GitRepository.Equals(input.GitRepository))) return false;
            if (this.RepoStatus != input.RepoStatus || (this.RepoStatus != null && !this.RepoStatus.Equals(input.RepoStatus))) return false;
            if (this.ClusterInfo != input.ClusterInfo || (this.ClusterInfo != null && !this.ClusterInfo.Equals(input.ClusterInfo))) return false;
            if (this.SecretInfo != input.SecretInfo || (this.SecretInfo != null && !this.SecretInfo.Equals(input.SecretInfo))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RepoType != null) hashCode = hashCode * 59 + this.RepoType.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.GitRepository != null) hashCode = hashCode * 59 + this.GitRepository.GetHashCode();
                if (this.RepoStatus != null) hashCode = hashCode * 59 + this.RepoStatus.GetHashCode();
                if (this.ClusterInfo != null) hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.SecretInfo != null) hashCode = hashCode * 59 + this.SecretInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
