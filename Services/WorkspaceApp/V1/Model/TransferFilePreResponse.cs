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
    public class TransferFilePreResponse : SdkResponse
    {

        /// <summary>
        /// 待流转文件url。
        /// </summary>
        [JsonProperty("target_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetFileUrl { get; set; }

        /// <summary>
        /// 文件系统名称。
        /// </summary>
        [JsonProperty("file_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSystemName { get; set; }

        /// <summary>
        /// 用户可自定义的文件夹名称。
        /// </summary>
        [JsonProperty("folder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferFilePreResponse {\n");
            sb.Append("  targetFileUrl: ").Append(TargetFileUrl).Append("\n");
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
            return this.Equals(input as TransferFilePreResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferFilePreResponse input)
        {
            if (input == null) return false;
            if (this.TargetFileUrl != input.TargetFileUrl || (this.TargetFileUrl != null && !this.TargetFileUrl.Equals(input.TargetFileUrl))) return false;
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
                if (this.TargetFileUrl != null) hashCode = hashCode * 59 + this.TargetFileUrl.GetHashCode();
                if (this.FileSystemName != null) hashCode = hashCode * 59 + this.FileSystemName.GetHashCode();
                if (this.FolderName != null) hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                return hashCode;
            }
        }
    }
}
