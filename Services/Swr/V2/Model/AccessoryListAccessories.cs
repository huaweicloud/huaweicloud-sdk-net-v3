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
    public class AccessoryListAccessories 
    {

        /// <summary>
        /// 附件编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 附件所属的租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 附件所属的组织
        /// </summary>
        [JsonProperty("namespace_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// 附件所属的仓库
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 附件镜像的版本
        /// </summary>
        [JsonProperty("sig_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string SigTag { get; set; }

        /// <summary>
        /// 附件镜像的hash值
        /// </summary>
        [JsonProperty("sig_digest", NullValueHandling = NullValueHandling.Ignore)]
        public string SigDigest { get; set; }

        /// <summary>
        /// 附件关联镜像的hash值
        /// </summary>
        [JsonProperty("target_digest", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDigest { get; set; }

        /// <summary>
        /// 附件镜像的大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 附件的类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessoryListAccessories {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  namespaceName: ").Append(NamespaceName).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  sigTag: ").Append(SigTag).Append("\n");
            sb.Append("  sigDigest: ").Append(SigDigest).Append("\n");
            sb.Append("  targetDigest: ").Append(TargetDigest).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessoryListAccessories);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessoryListAccessories input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.NamespaceName != input.NamespaceName || (this.NamespaceName != null && !this.NamespaceName.Equals(input.NamespaceName))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.SigTag != input.SigTag || (this.SigTag != null && !this.SigTag.Equals(input.SigTag))) return false;
            if (this.SigDigest != input.SigDigest || (this.SigDigest != null && !this.SigDigest.Equals(input.SigDigest))) return false;
            if (this.TargetDigest != input.TargetDigest || (this.TargetDigest != null && !this.TargetDigest.Equals(input.TargetDigest))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.NamespaceName != null) hashCode = hashCode * 59 + this.NamespaceName.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.SigTag != null) hashCode = hashCode * 59 + this.SigTag.GetHashCode();
                if (this.SigDigest != null) hashCode = hashCode * 59 + this.SigDigest.GetHashCode();
                if (this.TargetDigest != null) hashCode = hashCode * 59 + this.TargetDigest.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
