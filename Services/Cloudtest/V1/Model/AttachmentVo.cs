using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class AttachmentVo 
    {

        /// <summary>
        /// 附件Uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public string Updator { get; set; }

        /// <summary>
        /// 逻辑region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("doc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocId { get; set; }

        /// <summary>
        /// 父节点Uri
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 父节点类型
        /// </summary>
        [JsonProperty("parent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentType { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 保存文件名
        /// </summary>
        [JsonProperty("store_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreFileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSize { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 系统区分：docman或testman
        /// </summary>
        [JsonProperty("system_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("create_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeTimestamp { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 更新时间时间戳
        /// </summary>
        [JsonProperty("update_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeTimestamp { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 附件类型 0 本地上传  other 关联文档
        /// </summary>
        [JsonProperty("related_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  docId: ").Append(DocId).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  parentType: ").Append(ParentType).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  storeFileName: ").Append(StoreFileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  systemType: ").Append(SystemType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeTimestamp: ").Append(CreateTimeTimestamp).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeTimestamp: ").Append(UpdateTimeTimestamp).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  relatedType: ").Append(RelatedType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.DocId != input.DocId || (this.DocId != null && !this.DocId.Equals(input.DocId))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.ParentType != input.ParentType || (this.ParentType != null && !this.ParentType.Equals(input.ParentType))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.StoreFileName != input.StoreFileName || (this.StoreFileName != null && !this.StoreFileName.Equals(input.StoreFileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.SystemType != input.SystemType || (this.SystemType != null && !this.SystemType.Equals(input.SystemType))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeTimestamp != input.CreateTimeTimestamp || (this.CreateTimeTimestamp != null && !this.CreateTimeTimestamp.Equals(input.CreateTimeTimestamp))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeTimestamp != input.UpdateTimeTimestamp || (this.UpdateTimeTimestamp != null && !this.UpdateTimeTimestamp.Equals(input.UpdateTimeTimestamp))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.RelatedType != input.RelatedType || (this.RelatedType != null && !this.RelatedType.Equals(input.RelatedType))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.DocId != null) hashCode = hashCode * 59 + this.DocId.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.ParentType != null) hashCode = hashCode * 59 + this.ParentType.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.StoreFileName != null) hashCode = hashCode * 59 + this.StoreFileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.SystemType != null) hashCode = hashCode * 59 + this.SystemType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeTimestamp != null) hashCode = hashCode * 59 + this.CreateTimeTimestamp.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimeTimestamp.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.RelatedType != null) hashCode = hashCode * 59 + this.RelatedType.GetHashCode();
                return hashCode;
            }
        }
    }
}
