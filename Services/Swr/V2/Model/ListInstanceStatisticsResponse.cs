using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 已用存储空间
        /// </summary>
        [JsonProperty("storage_used", NullValueHandling = NullValueHandling.Ignore)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// 命名空间的总数
        /// </summary>
        [JsonProperty("total_namespace_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalNamespaceCount { get; set; }

        /// <summary>
        /// 镜像的总数
        /// </summary>
        [JsonProperty("total_image_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalImageCount { get; set; }

        /// <summary>
        /// 命名空间的配额
        /// </summary>
        [JsonProperty("namespace_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? NamespaceQuota { get; set; }

        /// <summary>
        /// 镜像的配额
        /// </summary>
        [JsonProperty("image_repo_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? ImageRepoQuota { get; set; }

        /// <summary>
        /// 镜像同步策略的配额
        /// </summary>
        [JsonProperty("replica_policy_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplicaPolicyQuota { get; set; }

        /// <summary>
        /// 镜像老化策略的配额
        /// </summary>
        [JsonProperty("retention_policy_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? RetentionPolicyQuota { get; set; }

        /// <summary>
        /// 触发器的配额
        /// </summary>
        [JsonProperty("notify_policy_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? NotifyPolicyQuota { get; set; }

        /// <summary>
        /// 镜像同步的目标仓库配额
        /// </summary>
        [JsonProperty("replica_registry_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplicaRegistryQuota { get; set; }

        /// <summary>
        /// 镜像签名策略的配额
        /// </summary>
        [JsonProperty("sign_policy_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? SignPolicyQuota { get; set; }

        /// <summary>
        /// 镜像同步策略总数
        /// </summary>
        [JsonProperty("replica_policy_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplicaPolicyCount { get; set; }

        /// <summary>
        /// 镜像老化策略的总数
        /// </summary>
        [JsonProperty("retention_policy_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RetentionPolicyCount { get; set; }

        /// <summary>
        /// 触发器的总数
        /// </summary>
        [JsonProperty("notify_policy_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? NotifyPolicyCount { get; set; }

        /// <summary>
        /// 镜像同步策略的目标仓库总数
        /// </summary>
        [JsonProperty("replica_registry_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplicaRegistryCount { get; set; }

        /// <summary>
        /// 内网访问控制的配额
        /// </summary>
        [JsonProperty("intranet_endpoint_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntranetEndpointQuota { get; set; }

        /// <summary>
        /// 内网访问控制的总数
        /// </summary>
        [JsonProperty("intranet_endpoint_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntranetEndpointCount { get; set; }

        /// <summary>
        /// 长期登录指令的配额
        /// </summary>
        [JsonProperty("long_term_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? LongTermQuota { get; set; }

        /// <summary>
        /// 镜像签名策略的总数
        /// </summary>
        [JsonProperty("sign_policy_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SignPolicyCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceStatisticsResponse {\n");
            sb.Append("  storageUsed: ").Append(StorageUsed).Append("\n");
            sb.Append("  totalNamespaceCount: ").Append(TotalNamespaceCount).Append("\n");
            sb.Append("  totalImageCount: ").Append(TotalImageCount).Append("\n");
            sb.Append("  namespaceQuota: ").Append(NamespaceQuota).Append("\n");
            sb.Append("  imageRepoQuota: ").Append(ImageRepoQuota).Append("\n");
            sb.Append("  replicaPolicyQuota: ").Append(ReplicaPolicyQuota).Append("\n");
            sb.Append("  retentionPolicyQuota: ").Append(RetentionPolicyQuota).Append("\n");
            sb.Append("  notifyPolicyQuota: ").Append(NotifyPolicyQuota).Append("\n");
            sb.Append("  replicaRegistryQuota: ").Append(ReplicaRegistryQuota).Append("\n");
            sb.Append("  signPolicyQuota: ").Append(SignPolicyQuota).Append("\n");
            sb.Append("  replicaPolicyCount: ").Append(ReplicaPolicyCount).Append("\n");
            sb.Append("  retentionPolicyCount: ").Append(RetentionPolicyCount).Append("\n");
            sb.Append("  notifyPolicyCount: ").Append(NotifyPolicyCount).Append("\n");
            sb.Append("  replicaRegistryCount: ").Append(ReplicaRegistryCount).Append("\n");
            sb.Append("  intranetEndpointQuota: ").Append(IntranetEndpointQuota).Append("\n");
            sb.Append("  intranetEndpointCount: ").Append(IntranetEndpointCount).Append("\n");
            sb.Append("  longTermQuota: ").Append(LongTermQuota).Append("\n");
            sb.Append("  signPolicyCount: ").Append(SignPolicyCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.StorageUsed != input.StorageUsed || (this.StorageUsed != null && !this.StorageUsed.Equals(input.StorageUsed))) return false;
            if (this.TotalNamespaceCount != input.TotalNamespaceCount || (this.TotalNamespaceCount != null && !this.TotalNamespaceCount.Equals(input.TotalNamespaceCount))) return false;
            if (this.TotalImageCount != input.TotalImageCount || (this.TotalImageCount != null && !this.TotalImageCount.Equals(input.TotalImageCount))) return false;
            if (this.NamespaceQuota != input.NamespaceQuota || (this.NamespaceQuota != null && !this.NamespaceQuota.Equals(input.NamespaceQuota))) return false;
            if (this.ImageRepoQuota != input.ImageRepoQuota || (this.ImageRepoQuota != null && !this.ImageRepoQuota.Equals(input.ImageRepoQuota))) return false;
            if (this.ReplicaPolicyQuota != input.ReplicaPolicyQuota || (this.ReplicaPolicyQuota != null && !this.ReplicaPolicyQuota.Equals(input.ReplicaPolicyQuota))) return false;
            if (this.RetentionPolicyQuota != input.RetentionPolicyQuota || (this.RetentionPolicyQuota != null && !this.RetentionPolicyQuota.Equals(input.RetentionPolicyQuota))) return false;
            if (this.NotifyPolicyQuota != input.NotifyPolicyQuota || (this.NotifyPolicyQuota != null && !this.NotifyPolicyQuota.Equals(input.NotifyPolicyQuota))) return false;
            if (this.ReplicaRegistryQuota != input.ReplicaRegistryQuota || (this.ReplicaRegistryQuota != null && !this.ReplicaRegistryQuota.Equals(input.ReplicaRegistryQuota))) return false;
            if (this.SignPolicyQuota != input.SignPolicyQuota || (this.SignPolicyQuota != null && !this.SignPolicyQuota.Equals(input.SignPolicyQuota))) return false;
            if (this.ReplicaPolicyCount != input.ReplicaPolicyCount || (this.ReplicaPolicyCount != null && !this.ReplicaPolicyCount.Equals(input.ReplicaPolicyCount))) return false;
            if (this.RetentionPolicyCount != input.RetentionPolicyCount || (this.RetentionPolicyCount != null && !this.RetentionPolicyCount.Equals(input.RetentionPolicyCount))) return false;
            if (this.NotifyPolicyCount != input.NotifyPolicyCount || (this.NotifyPolicyCount != null && !this.NotifyPolicyCount.Equals(input.NotifyPolicyCount))) return false;
            if (this.ReplicaRegistryCount != input.ReplicaRegistryCount || (this.ReplicaRegistryCount != null && !this.ReplicaRegistryCount.Equals(input.ReplicaRegistryCount))) return false;
            if (this.IntranetEndpointQuota != input.IntranetEndpointQuota || (this.IntranetEndpointQuota != null && !this.IntranetEndpointQuota.Equals(input.IntranetEndpointQuota))) return false;
            if (this.IntranetEndpointCount != input.IntranetEndpointCount || (this.IntranetEndpointCount != null && !this.IntranetEndpointCount.Equals(input.IntranetEndpointCount))) return false;
            if (this.LongTermQuota != input.LongTermQuota || (this.LongTermQuota != null && !this.LongTermQuota.Equals(input.LongTermQuota))) return false;
            if (this.SignPolicyCount != input.SignPolicyCount || (this.SignPolicyCount != null && !this.SignPolicyCount.Equals(input.SignPolicyCount))) return false;

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
                if (this.StorageUsed != null) hashCode = hashCode * 59 + this.StorageUsed.GetHashCode();
                if (this.TotalNamespaceCount != null) hashCode = hashCode * 59 + this.TotalNamespaceCount.GetHashCode();
                if (this.TotalImageCount != null) hashCode = hashCode * 59 + this.TotalImageCount.GetHashCode();
                if (this.NamespaceQuota != null) hashCode = hashCode * 59 + this.NamespaceQuota.GetHashCode();
                if (this.ImageRepoQuota != null) hashCode = hashCode * 59 + this.ImageRepoQuota.GetHashCode();
                if (this.ReplicaPolicyQuota != null) hashCode = hashCode * 59 + this.ReplicaPolicyQuota.GetHashCode();
                if (this.RetentionPolicyQuota != null) hashCode = hashCode * 59 + this.RetentionPolicyQuota.GetHashCode();
                if (this.NotifyPolicyQuota != null) hashCode = hashCode * 59 + this.NotifyPolicyQuota.GetHashCode();
                if (this.ReplicaRegistryQuota != null) hashCode = hashCode * 59 + this.ReplicaRegistryQuota.GetHashCode();
                if (this.SignPolicyQuota != null) hashCode = hashCode * 59 + this.SignPolicyQuota.GetHashCode();
                if (this.ReplicaPolicyCount != null) hashCode = hashCode * 59 + this.ReplicaPolicyCount.GetHashCode();
                if (this.RetentionPolicyCount != null) hashCode = hashCode * 59 + this.RetentionPolicyCount.GetHashCode();
                if (this.NotifyPolicyCount != null) hashCode = hashCode * 59 + this.NotifyPolicyCount.GetHashCode();
                if (this.ReplicaRegistryCount != null) hashCode = hashCode * 59 + this.ReplicaRegistryCount.GetHashCode();
                if (this.IntranetEndpointQuota != null) hashCode = hashCode * 59 + this.IntranetEndpointQuota.GetHashCode();
                if (this.IntranetEndpointCount != null) hashCode = hashCode * 59 + this.IntranetEndpointCount.GetHashCode();
                if (this.LongTermQuota != null) hashCode = hashCode * 59 + this.LongTermQuota.GetHashCode();
                if (this.SignPolicyCount != null) hashCode = hashCode * 59 + this.SignPolicyCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
