using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FilesResponseInfo 
    {

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// 编码类型
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        /// <summary>
        /// 文件块id
        /// </summary>
        [JsonProperty("blob_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesResponseInfo {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  blobId: ").Append(BlobId).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilesResponseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FilesResponseInfo input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Encoding != input.Encoding || (this.Encoding != null && !this.Encoding.Equals(input.Encoding))) return false;
            if (this.Ref != input.Ref || (this.Ref != null && !this.Ref.Equals(input.Ref))) return false;
            if (this.BlobId != input.BlobId || (this.BlobId != null && !this.BlobId.Equals(input.BlobId))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;

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
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Encoding != null) hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.Ref != null) hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.BlobId != null) hashCode = hashCode * 59 + this.BlobId.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
