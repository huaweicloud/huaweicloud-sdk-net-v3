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
    /// Response Object
    /// </summary>
    public class ShowConfigSetResponse : SdkResponse
    {

        /// <summary>
        /// 配置集合的唯一标识
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

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
        /// 仓库名称
        /// </summary>
        [JsonProperty("repoName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// bucket基本信息
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public Object Bucket { get; set; }

        /// <summary>
        /// Helm Chart源基本信息
        /// </summary>
        [JsonProperty("helmChart", NullValueHandling = NullValueHandling.Ignore)]
        public Object HelmChart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gitRepository", NullValueHandling = NullValueHandling.Ignore)]
        public GitRepository GitRepository { get; set; }

        /// <summary>
        /// Helm仓库的定义与状态等信息
        /// </summary>
        [JsonProperty("helmRepository", NullValueHandling = NullValueHandling.Ignore)]
        public Object HelmRepository { get; set; }

        /// <summary>
        /// 仓库状态信息
        /// </summary>
        [JsonProperty("repoStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoStatus { get; set; }

        /// <summary>
        /// Helm Chart的发布配置和状态信息
        /// </summary>
        [JsonProperty("helmRelease", NullValueHandling = NullValueHandling.Ignore)]
        public Object HelmRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kustomization", NullValueHandling = NullValueHandling.Ignore)]
        public Kustomization Kustomization { get; set; }

        /// <summary>
        /// 配置集合状态信息
        /// </summary>
        [JsonProperty("configSetStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigSetStatus { get; set; }

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
            sb.Append("class ShowConfigSetResponse {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  configSetType: ").Append(ConfigSetType).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  helmChart: ").Append(HelmChart).Append("\n");
            sb.Append("  gitRepository: ").Append(GitRepository).Append("\n");
            sb.Append("  helmRepository: ").Append(HelmRepository).Append("\n");
            sb.Append("  repoStatus: ").Append(RepoStatus).Append("\n");
            sb.Append("  helmRelease: ").Append(HelmRelease).Append("\n");
            sb.Append("  kustomization: ").Append(Kustomization).Append("\n");
            sb.Append("  configSetStatus: ").Append(ConfigSetStatus).Append("\n");
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
            return this.Equals(input as ShowConfigSetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigSetResponse input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ConfigSetType != input.ConfigSetType || (this.ConfigSetType != null && !this.ConfigSetType.Equals(input.ConfigSetType))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.HelmChart != input.HelmChart || (this.HelmChart != null && !this.HelmChart.Equals(input.HelmChart))) return false;
            if (this.GitRepository != input.GitRepository || (this.GitRepository != null && !this.GitRepository.Equals(input.GitRepository))) return false;
            if (this.HelmRepository != input.HelmRepository || (this.HelmRepository != null && !this.HelmRepository.Equals(input.HelmRepository))) return false;
            if (this.RepoStatus != input.RepoStatus || (this.RepoStatus != null && !this.RepoStatus.Equals(input.RepoStatus))) return false;
            if (this.HelmRelease != input.HelmRelease || (this.HelmRelease != null && !this.HelmRelease.Equals(input.HelmRelease))) return false;
            if (this.Kustomization != input.Kustomization || (this.Kustomization != null && !this.Kustomization.Equals(input.Kustomization))) return false;
            if (this.ConfigSetStatus != input.ConfigSetStatus || (this.ConfigSetStatus != null && !this.ConfigSetStatus.Equals(input.ConfigSetStatus))) return false;
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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ConfigSetType != null) hashCode = hashCode * 59 + this.ConfigSetType.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.HelmChart != null) hashCode = hashCode * 59 + this.HelmChart.GetHashCode();
                if (this.GitRepository != null) hashCode = hashCode * 59 + this.GitRepository.GetHashCode();
                if (this.HelmRepository != null) hashCode = hashCode * 59 + this.HelmRepository.GetHashCode();
                if (this.RepoStatus != null) hashCode = hashCode * 59 + this.RepoStatus.GetHashCode();
                if (this.HelmRelease != null) hashCode = hashCode * 59 + this.HelmRelease.GetHashCode();
                if (this.Kustomization != null) hashCode = hashCode * 59 + this.Kustomization.GetHashCode();
                if (this.ConfigSetStatus != null) hashCode = hashCode * 59 + this.ConfigSetStatus.GetHashCode();
                if (this.ClusterInfo != null) hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.SecretInfo != null) hashCode = hashCode * 59 + this.SecretInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
