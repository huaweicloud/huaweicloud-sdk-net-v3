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
    /// 
    /// </summary>
    public class SyncRepo 
    {

        /// <summary>
        /// 创建时间，UTC日期格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domainID", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainID { get; set; }

        /// <summary>
        /// 租户名
        /// </summary>
        [JsonProperty("domainName", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 组织名
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 是否覆盖
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override { get; set; }

        /// <summary>
        /// 目的组织
        /// </summary>
        [JsonProperty("remoteNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteNamespace { get; set; }

        /// <summary>
        /// 目的region
        /// </summary>
        [JsonProperty("remoteRegionId", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteRegionId { get; set; }

        /// <summary>
        /// 仓库名
        /// </summary>
        [JsonProperty("repoName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 自动同步
        /// </summary>
        [JsonProperty("syncAuto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncAuto { get; set; }

        /// <summary>
        /// 更新时间，UTC日期格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncRepo {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  domainID: ").Append(DomainID).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  remoteNamespace: ").Append(RemoteNamespace).Append("\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  syncAuto: ").Append(SyncAuto).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SyncRepo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SyncRepo input)
        {
            if (input == null) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.DomainID != input.DomainID || (this.DomainID != null && !this.DomainID.Equals(input.DomainID))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Override != input.Override || (this.Override != null && !this.Override.Equals(input.Override))) return false;
            if (this.RemoteNamespace != input.RemoteNamespace || (this.RemoteNamespace != null && !this.RemoteNamespace.Equals(input.RemoteNamespace))) return false;
            if (this.RemoteRegionId != input.RemoteRegionId || (this.RemoteRegionId != null && !this.RemoteRegionId.Equals(input.RemoteRegionId))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.SyncAuto != input.SyncAuto || (this.SyncAuto != null && !this.SyncAuto.Equals(input.SyncAuto))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DomainID != null) hashCode = hashCode * 59 + this.DomainID.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Override != null) hashCode = hashCode * 59 + this.Override.GetHashCode();
                if (this.RemoteNamespace != null) hashCode = hashCode * 59 + this.RemoteNamespace.GetHashCode();
                if (this.RemoteRegionId != null) hashCode = hashCode * 59 + this.RemoteRegionId.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.SyncAuto != null) hashCode = hashCode * 59 + this.SyncAuto.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
