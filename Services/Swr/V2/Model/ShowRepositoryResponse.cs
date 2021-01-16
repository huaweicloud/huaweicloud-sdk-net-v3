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
    public class ShowRepositoryResponse : SdkResponse
    {

        /// <summary>
        /// 仓库编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 命名空间编号
        /// </summary>
        [JsonProperty("ns_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? NsId { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 仓库类型（计划改造，每个镜像会有多个lable标示）
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 仓库描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 仓库创建者id
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 仓库创建者
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 仓库大小 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 仓库是否为公共仓库，值为true或false
        /// </summary>
        [JsonProperty("is_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 仓库中镜像个数，0 ~ 9223372036854775807
        /// </summary>
        [JsonProperty("num_images", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumImages { get; set; }

        /// <summary>
        /// 仓库下载次数
        /// </summary>
        [JsonProperty("num_download", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumDownload { get; set; }

        /// <summary>
        /// 仓库logo图片的URL，URL格式。（暂时未用）
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 镜像pull路径，格式为 swr.cn-north-1.myhuaweicloud.com/namespace/repository
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 镜像pull路径，格式为 10.125.0.198:20202/namespace/repository
        /// </summary>
        [JsonProperty("internal_path", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalPath { get; set; }

        /// <summary>
        /// 仓库创建时间，UTC日期格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 仓库更新时间，UTC日期格式，时间为UTC标准时间，用户需要根据本地时间计算偏移量；如东8区需要+8:00
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  nsId: ").Append(NsId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  isPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  numImages: ").Append(NumImages).Append("\n");
            sb.Append("  numDownload: ").Append(NumDownload).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  internalPath: ").Append(InternalPath).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryResponse input)
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
                    this.NsId == input.NsId ||
                    (this.NsId != null &&
                    this.NsId.Equals(input.NsId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.CreatorName == input.CreatorName ||
                    (this.CreatorName != null &&
                    this.CreatorName.Equals(input.CreatorName))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
                ) && 
                (
                    this.NumImages == input.NumImages ||
                    (this.NumImages != null &&
                    this.NumImages.Equals(input.NumImages))
                ) && 
                (
                    this.NumDownload == input.NumDownload ||
                    (this.NumDownload != null &&
                    this.NumDownload.Equals(input.NumDownload))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.NsId != null)
                    hashCode = hashCode * 59 + this.NsId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorName != null)
                    hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.NumImages != null)
                    hashCode = hashCode * 59 + this.NumImages.GetHashCode();
                if (this.NumDownload != null)
                    hashCode = hashCode * 59 + this.NumDownload.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.InternalPath != null)
                    hashCode = hashCode * 59 + this.InternalPath.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }
    }
}
