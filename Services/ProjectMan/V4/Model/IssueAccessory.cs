using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IssueAccessory 
    {

        /// <summary>
        /// 附件id
        /// </summary>
        [JsonProperty("attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentId { get; set; }

        /// <summary>
        /// 工作鞋ID
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// 创建者数字ID
        /// </summary>
        [JsonProperty("creator_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorNumId { get; set; }

        /// <summary>
        /// 附件创建时间
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 上传时文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 附件id
        /// </summary>
        [JsonProperty("container_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerType { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [JsonProperty("disk_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskFileName { get; set; }

        /// <summary>
        /// 附件id
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// 附件路径
        /// </summary>
        [JsonProperty("disk_directory", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskDirectory { get; set; }

        /// <summary>
        /// 创建这用户uuid
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueAccessory {\n");
            sb.Append("  attachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  creatorNumId: ").Append(CreatorNumId).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  containerType: ").Append(ContainerType).Append("\n");
            sb.Append("  diskFileName: ").Append(DiskFileName).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  diskDirectory: ").Append(DiskDirectory).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueAccessory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueAccessory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachmentId == input.AttachmentId ||
                    (this.AttachmentId != null &&
                    this.AttachmentId.Equals(input.AttachmentId))
                ) && 
                (
                    this.IssueId == input.IssueId ||
                    (this.IssueId != null &&
                    this.IssueId.Equals(input.IssueId))
                ) && 
                (
                    this.CreatorNumId == input.CreatorNumId ||
                    (this.CreatorNumId != null &&
                    this.CreatorNumId.Equals(input.CreatorNumId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.ContainerType == input.ContainerType ||
                    (this.ContainerType != null &&
                    this.ContainerType.Equals(input.ContainerType))
                ) && 
                (
                    this.DiskFileName == input.DiskFileName ||
                    (this.DiskFileName != null &&
                    this.DiskFileName.Equals(input.DiskFileName))
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.DiskDirectory == input.DiskDirectory ||
                    (this.DiskDirectory != null &&
                    this.DiskDirectory.Equals(input.DiskDirectory))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
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
                if (this.AttachmentId != null)
                    hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                if (this.IssueId != null)
                    hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.CreatorNumId != null)
                    hashCode = hashCode * 59 + this.CreatorNumId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.ContainerType != null)
                    hashCode = hashCode * 59 + this.ContainerType.GetHashCode();
                if (this.DiskFileName != null)
                    hashCode = hashCode * 59 + this.DiskFileName.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.DiskDirectory != null)
                    hashCode = hashCode * 59 + this.DiskDirectory.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
