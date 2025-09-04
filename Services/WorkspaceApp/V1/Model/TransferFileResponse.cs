using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class TransferFileResponse : SdkResponse
    {

        /// <summary>
        /// 待流转文件url。
        /// </summary>
        [JsonProperty("file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文件编码。
        /// </summary>
        [JsonProperty("file_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileCode { get; set; }

        /// <summary>
        /// 文件提取码。
        /// </summary>
        [JsonProperty("file_acc_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileAccCode { get; set; }

        /// <summary>
        /// 文件系统名称。
        /// </summary>
        [JsonProperty("file_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSystemName { get; set; }

        /// <summary>
        /// 文件夹名称。
        /// </summary>
        [JsonProperty("folder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferFileResponse {\n");
            sb.Append("  fileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  fileCode: ").Append(FileCode).Append("\n");
            sb.Append("  fileAccCode: ").Append(FileAccCode).Append("\n");
            sb.Append("  fileSystemName: ").Append(FileSystemName).Append("\n");
            sb.Append("  folderName: ").Append(FolderName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferFileResponse input)
        {
            if (input == null) return false;
            if (this.FileUrl != input.FileUrl || (this.FileUrl != null && !this.FileUrl.Equals(input.FileUrl))) return false;
            if (this.FileCode != input.FileCode || (this.FileCode != null && !this.FileCode.Equals(input.FileCode))) return false;
            if (this.FileAccCode != input.FileAccCode || (this.FileAccCode != null && !this.FileAccCode.Equals(input.FileAccCode))) return false;
            if (this.FileSystemName != input.FileSystemName || (this.FileSystemName != null && !this.FileSystemName.Equals(input.FileSystemName))) return false;
            if (this.FolderName != input.FolderName || (this.FolderName != null && !this.FolderName.Equals(input.FolderName))) return false;

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
                if (this.FileUrl != null) hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                if (this.FileCode != null) hashCode = hashCode * 59 + this.FileCode.GetHashCode();
                if (this.FileAccCode != null) hashCode = hashCode * 59 + this.FileAccCode.GetHashCode();
                if (this.FileSystemName != null) hashCode = hashCode * 59 + this.FileSystemName.GetHashCode();
                if (this.FolderName != null) hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                return hashCode;
            }
        }
    }
}
