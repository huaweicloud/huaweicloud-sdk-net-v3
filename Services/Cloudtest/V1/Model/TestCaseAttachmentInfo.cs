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
    /// 对外附件
    /// </summary>
    public class TestCaseAttachmentInfo 
    {

        /// <summary>
        /// 附件是否要被覆盖
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override { get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("doc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSize { get; set; }

        /// <summary>
        /// 重复用例ID
        /// </summary>
        [JsonProperty("override_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OverrideId { get; set; }

        /// <summary>
        /// 相关类型
        /// </summary>
        [JsonProperty("related_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedType { get; set; }

        /// <summary>
        /// 保存文件名
        /// </summary>
        [JsonProperty("store_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreFileName { get; set; }

        /// <summary>
        /// 系统区分
        /// </summary>
        [JsonProperty("system_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemType { get; set; }

        /// <summary>
        /// 区分文件存储系统
        /// </summary>
        [JsonProperty("storage_system", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSystem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseAttachmentInfo {\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  docId: ").Append(DocId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  overrideId: ").Append(OverrideId).Append("\n");
            sb.Append("  relatedType: ").Append(RelatedType).Append("\n");
            sb.Append("  storeFileName: ").Append(StoreFileName).Append("\n");
            sb.Append("  systemType: ").Append(SystemType).Append("\n");
            sb.Append("  storageSystem: ").Append(StorageSystem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseAttachmentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseAttachmentInfo input)
        {
            if (input == null) return false;
            if (this.Override != input.Override || (this.Override != null && !this.Override.Equals(input.Override))) return false;
            if (this.DocId != input.DocId || (this.DocId != null && !this.DocId.Equals(input.DocId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.OverrideId != input.OverrideId || (this.OverrideId != null && !this.OverrideId.Equals(input.OverrideId))) return false;
            if (this.RelatedType != input.RelatedType || (this.RelatedType != null && !this.RelatedType.Equals(input.RelatedType))) return false;
            if (this.StoreFileName != input.StoreFileName || (this.StoreFileName != null && !this.StoreFileName.Equals(input.StoreFileName))) return false;
            if (this.SystemType != input.SystemType || (this.SystemType != null && !this.SystemType.Equals(input.SystemType))) return false;
            if (this.StorageSystem != input.StorageSystem || (this.StorageSystem != null && !this.StorageSystem.Equals(input.StorageSystem))) return false;

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
                if (this.Override != null) hashCode = hashCode * 59 + this.Override.GetHashCode();
                if (this.DocId != null) hashCode = hashCode * 59 + this.DocId.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.OverrideId != null) hashCode = hashCode * 59 + this.OverrideId.GetHashCode();
                if (this.RelatedType != null) hashCode = hashCode * 59 + this.RelatedType.GetHashCode();
                if (this.StoreFileName != null) hashCode = hashCode * 59 + this.StoreFileName.GetHashCode();
                if (this.SystemType != null) hashCode = hashCode * 59 + this.SystemType.GetHashCode();
                if (this.StorageSystem != null) hashCode = hashCode * 59 + this.StorageSystem.GetHashCode();
                return hashCode;
            }
        }
    }
}
