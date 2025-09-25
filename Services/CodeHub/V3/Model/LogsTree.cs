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
    public class LogsTree 
    {

        /// <summary>
        /// 存储块id
        /// </summary>
        [JsonProperty("blob_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public Commit Commit { get; set; }

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
        /// MD5
        /// </summary>
        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }

        /// <summary>
        /// 存储类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogsTree {\n");
            sb.Append("  blobId: ").Append(BlobId).Append("\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  md5: ").Append(Md5).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogsTree);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogsTree input)
        {
            if (input == null) return false;
            if (this.BlobId != input.BlobId || (this.BlobId != null && !this.BlobId.Equals(input.BlobId))) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.Md5 != input.Md5 || (this.Md5 != null && !this.Md5.Equals(input.Md5))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.BlobId != null) hashCode = hashCode * 59 + this.BlobId.GetHashCode();
                if (this.Commit != null) hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Md5 != null) hashCode = hashCode * 59 + this.Md5.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
