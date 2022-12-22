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
    public class ShowReposTagResp 
    {

        /// <summary>
        /// tag编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? RepoId { get; set; }

        /// <summary>
        /// Tag版本名称
        /// </summary>
        [JsonProperty("Tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像manifest
        /// </summary>
        [JsonProperty("manifest", NullValueHandling = NullValueHandling.Ignore)]
        public string Manifest { get; set; }

        /// <summary>
        /// 镜像hash值
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// docker协议版本，值为1或2
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public long? Schema { get; set; }

        /// <summary>
        /// 镜像pull地址，格式为swr.cn-north-1.myhuaweicloud.com/namespace/repository:tag
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// cce集群内镜像pull路径，格式为 10.125.0.198:20202/namespace/repository:tag
        /// </summary>
        [JsonProperty("internal_path", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalPath { get; set; }

        /// <summary>
        /// 镜像大小，0 ~ 9223372036854775807
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 默认值为false
        /// </summary>
        [JsonProperty("is_trusted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTrusted { get; set; }

        /// <summary>
        /// 镜像创建时间，UTC时间格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 镜像更新时间，UTC时间格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 镜像删除时间，UTC时间格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string Deleted { get; set; }

        /// <summary>
        /// 帐号ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 镜像是否被扫描过
        /// </summary>
        [JsonProperty("scanned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Scanned { get; set; }

        /// <summary>
        /// 0：manifest类型；1：manifest list类型
        /// </summary>
        [JsonProperty("tag_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? TagType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReposTagResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  manifest: ").Append(Manifest).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  internalPath: ").Append(InternalPath).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  isTrusted: ").Append(IsTrusted).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  scanned: ").Append(Scanned).Append("\n");
            sb.Append("  tagType: ").Append(TagType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReposTagResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReposTagResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RepoId == input.RepoId ||
                    (this.RepoId != null &&
                    this.RepoId.Equals(input.RepoId))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.InternalPath == input.InternalPath ||
                    (this.InternalPath != null &&
                    this.InternalPath.Equals(input.InternalPath))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.IsTrusted == input.IsTrusted ||
                    (this.IsTrusted != null &&
                    this.IsTrusted.Equals(input.IsTrusted))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Scanned == input.Scanned ||
                    (this.Scanned != null &&
                    this.Scanned.Equals(input.Scanned))
                ) && 
                (
                    this.TagType == input.TagType ||
                    (this.TagType != null &&
                    this.TagType.Equals(input.TagType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RepoId != null)
                    hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.InternalPath != null)
                    hashCode = hashCode * 59 + this.InternalPath.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.IsTrusted != null)
                    hashCode = hashCode * 59 + this.IsTrusted.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Scanned != null)
                    hashCode = hashCode * 59 + this.Scanned.GetHashCode();
                if (this.TagType != null)
                    hashCode = hashCode * 59 + this.TagType.GetHashCode();
                return hashCode;
            }
        }
    }
}
