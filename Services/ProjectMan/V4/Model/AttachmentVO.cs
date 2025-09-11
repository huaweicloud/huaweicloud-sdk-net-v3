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
    public class AttachmentVO 
    {

        /// <summary>
        /// 附件类型
        /// </summary>
        [JsonProperty("attachment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentType { get; set; }

        /// <summary>
        /// 创建人信息
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public Object CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 附件描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 存储路径
        /// </summary>
        [JsonProperty("disk_directory", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskDirectory { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("filesize", NullValueHandling = NullValueHandling.Ignore)]
        public string Filesize { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 更新人信息
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public Object ModifiedBy { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("store_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreFilename { get; set; }

        /// <summary>
        /// 文件hash名称
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("workitem_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkitemId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentVO {\n");
            sb.Append("  attachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  diskDirectory: ").Append(DiskDirectory).Append("\n");
            sb.Append("  filesize: ").Append(Filesize).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  storeFilename: ").Append(StoreFilename).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  workitemId: ").Append(WorkitemId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentVO input)
        {
            if (input == null) return false;
            if (this.AttachmentType != input.AttachmentType || (this.AttachmentType != null && !this.AttachmentType.Equals(input.AttachmentType))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DiskDirectory != input.DiskDirectory || (this.DiskDirectory != null && !this.DiskDirectory.Equals(input.DiskDirectory))) return false;
            if (this.Filesize != input.Filesize || (this.Filesize != null && !this.Filesize.Equals(input.Filesize))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.StoreFilename != input.StoreFilename || (this.StoreFilename != null && !this.StoreFilename.Equals(input.StoreFilename))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.WorkitemId != input.WorkitemId || (this.WorkitemId != null && !this.WorkitemId.Equals(input.WorkitemId))) return false;

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
                if (this.AttachmentType != null) hashCode = hashCode * 59 + this.AttachmentType.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DiskDirectory != null) hashCode = hashCode * 59 + this.DiskDirectory.GetHashCode();
                if (this.Filesize != null) hashCode = hashCode * 59 + this.Filesize.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.StoreFilename != null) hashCode = hashCode * 59 + this.StoreFilename.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.WorkitemId != null) hashCode = hashCode * 59 + this.WorkitemId.GetHashCode();
                return hashCode;
            }
        }
    }
}
