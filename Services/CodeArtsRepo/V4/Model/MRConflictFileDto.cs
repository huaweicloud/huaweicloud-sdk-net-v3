using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 冲突文件详情
    /// </summary>
    public class MRConflictFileDto 
    {

        /// <summary>
        /// **参数解释：** 旧文件名称。
        /// </summary>
        [JsonProperty("old_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPath { get; set; }

        /// <summary>
        /// **参数解释：** 新文件名称。
        /// </summary>
        [JsonProperty("new_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPath { get; set; }

        /// <summary>
        /// blob_icon
        /// </summary>
        [JsonProperty("blob_icon", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobIcon { get; set; }

        /// <summary>
        /// blob 路径
        /// </summary>
        [JsonProperty("blob_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobPath { get; set; }

        /// <summary>
        /// 冲突类型
        /// </summary>
        [JsonProperty("conflict_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConflictType { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 内容路径
        /// </summary>
        [JsonProperty("content_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentPath { get; set; }

        /// <summary>
        /// 片段
        /// </summary>
        [JsonProperty("sections", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConflictSectionDto> Sections { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MRConflictFileDto {\n");
            sb.Append("  oldPath: ").Append(OldPath).Append("\n");
            sb.Append("  newPath: ").Append(NewPath).Append("\n");
            sb.Append("  blobIcon: ").Append(BlobIcon).Append("\n");
            sb.Append("  blobPath: ").Append(BlobPath).Append("\n");
            sb.Append("  conflictType: ").Append(ConflictType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  contentPath: ").Append(ContentPath).Append("\n");
            sb.Append("  sections: ").Append(Sections).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MRConflictFileDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MRConflictFileDto input)
        {
            if (input == null) return false;
            if (this.OldPath != input.OldPath || (this.OldPath != null && !this.OldPath.Equals(input.OldPath))) return false;
            if (this.NewPath != input.NewPath || (this.NewPath != null && !this.NewPath.Equals(input.NewPath))) return false;
            if (this.BlobIcon != input.BlobIcon || (this.BlobIcon != null && !this.BlobIcon.Equals(input.BlobIcon))) return false;
            if (this.BlobPath != input.BlobPath || (this.BlobPath != null && !this.BlobPath.Equals(input.BlobPath))) return false;
            if (this.ConflictType != input.ConflictType || (this.ConflictType != null && !this.ConflictType.Equals(input.ConflictType))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.ContentPath != input.ContentPath || (this.ContentPath != null && !this.ContentPath.Equals(input.ContentPath))) return false;
            if (this.Sections != input.Sections || (this.Sections != null && input.Sections != null && !this.Sections.SequenceEqual(input.Sections))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                if (this.OldPath != null) hashCode = hashCode * 59 + this.OldPath.GetHashCode();
                if (this.NewPath != null) hashCode = hashCode * 59 + this.NewPath.GetHashCode();
                if (this.BlobIcon != null) hashCode = hashCode * 59 + this.BlobIcon.GetHashCode();
                if (this.BlobPath != null) hashCode = hashCode * 59 + this.BlobPath.GetHashCode();
                if (this.ConflictType != null) hashCode = hashCode * 59 + this.ConflictType.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.ContentPath != null) hashCode = hashCode * 59 + this.ContentPath.GetHashCode();
                if (this.Sections != null) hashCode = hashCode * 59 + this.Sections.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
