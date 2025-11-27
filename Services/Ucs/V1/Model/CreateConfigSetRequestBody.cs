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
    /// 创建配置集请求
    /// </summary>
    public class CreateConfigSetRequestBody 
    {

        /// <summary>
        /// 配置集合的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 配置集合的类型
        /// </summary>
        [JsonProperty("configSetType", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigSetType { get; set; }

        /// <summary>
        /// 源代码仓库名称
        /// </summary>
        [JsonProperty("repoName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 对象存储桶的基本信息
        /// </summary>
        [JsonProperty("bucketSpec", NullValueHandling = NullValueHandling.Ignore)]
        public Object BucketSpec { get; set; }

        /// <summary>
        /// Helm Chart源基本信息
        /// </summary>
        [JsonProperty("helmChartSpec", NullValueHandling = NullValueHandling.Ignore)]
        public Object HelmChartSpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gitRepositorySpec", NullValueHandling = NullValueHandling.Ignore)]
        public GitRepositorySpec GitRepositorySpec { get; set; }

        /// <summary>
        /// Helm仓库基本信息
        /// </summary>
        [JsonProperty("helmRepositorySpec", NullValueHandling = NullValueHandling.Ignore)]
        public Object HelmRepositorySpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kustomizationSpec", NullValueHandling = NullValueHandling.Ignore)]
        public KustomizationSpec KustomizationSpec { get; set; }

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
            sb.Append("class CreateConfigSetRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  configSetType: ").Append(ConfigSetType).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  bucketSpec: ").Append(BucketSpec).Append("\n");
            sb.Append("  helmChartSpec: ").Append(HelmChartSpec).Append("\n");
            sb.Append("  gitRepositorySpec: ").Append(GitRepositorySpec).Append("\n");
            sb.Append("  helmRepositorySpec: ").Append(HelmRepositorySpec).Append("\n");
            sb.Append("  kustomizationSpec: ").Append(KustomizationSpec).Append("\n");
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
            return this.Equals(input as CreateConfigSetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateConfigSetRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ConfigSetType != input.ConfigSetType || (this.ConfigSetType != null && !this.ConfigSetType.Equals(input.ConfigSetType))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.BucketSpec != input.BucketSpec || (this.BucketSpec != null && !this.BucketSpec.Equals(input.BucketSpec))) return false;
            if (this.HelmChartSpec != input.HelmChartSpec || (this.HelmChartSpec != null && !this.HelmChartSpec.Equals(input.HelmChartSpec))) return false;
            if (this.GitRepositorySpec != input.GitRepositorySpec || (this.GitRepositorySpec != null && !this.GitRepositorySpec.Equals(input.GitRepositorySpec))) return false;
            if (this.HelmRepositorySpec != input.HelmRepositorySpec || (this.HelmRepositorySpec != null && !this.HelmRepositorySpec.Equals(input.HelmRepositorySpec))) return false;
            if (this.KustomizationSpec != input.KustomizationSpec || (this.KustomizationSpec != null && !this.KustomizationSpec.Equals(input.KustomizationSpec))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ConfigSetType != null) hashCode = hashCode * 59 + this.ConfigSetType.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.BucketSpec != null) hashCode = hashCode * 59 + this.BucketSpec.GetHashCode();
                if (this.HelmChartSpec != null) hashCode = hashCode * 59 + this.HelmChartSpec.GetHashCode();
                if (this.GitRepositorySpec != null) hashCode = hashCode * 59 + this.GitRepositorySpec.GetHashCode();
                if (this.HelmRepositorySpec != null) hashCode = hashCode * 59 + this.HelmRepositorySpec.GetHashCode();
                if (this.KustomizationSpec != null) hashCode = hashCode * 59 + this.KustomizationSpec.GetHashCode();
                if (this.ClusterInfo != null) hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.SecretInfo != null) hashCode = hashCode * 59 + this.SecretInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
