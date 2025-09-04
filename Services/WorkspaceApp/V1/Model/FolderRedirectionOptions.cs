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
    /// 文件夹重定向配置。
    /// </summary>
    public class FolderRedirectionOptions 
    {

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativePath { get; set; }

        /// <summary>
        /// 用户存储路径。
        /// </summary>
        [JsonProperty("storage_paths", NullValueHandling = NullValueHandling.Ignore)]
        public string StoragePaths { get; set; }

        /// <summary>
        /// 文件夹选项。
        /// </summary>
        [JsonProperty("include_common_folders", NullValueHandling = NullValueHandling.Ignore)]
        public int? IncludeCommonFolders { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderRedirectionOptions {\n");
            sb.Append("  relativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  storagePaths: ").Append(StoragePaths).Append("\n");
            sb.Append("  includeCommonFolders: ").Append(IncludeCommonFolders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FolderRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FolderRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.RelativePath != input.RelativePath || (this.RelativePath != null && !this.RelativePath.Equals(input.RelativePath))) return false;
            if (this.StoragePaths != input.StoragePaths || (this.StoragePaths != null && !this.StoragePaths.Equals(input.StoragePaths))) return false;
            if (this.IncludeCommonFolders != input.IncludeCommonFolders || (this.IncludeCommonFolders != null && !this.IncludeCommonFolders.Equals(input.IncludeCommonFolders))) return false;

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
                if (this.RelativePath != null) hashCode = hashCode * 59 + this.RelativePath.GetHashCode();
                if (this.StoragePaths != null) hashCode = hashCode * 59 + this.StoragePaths.GetHashCode();
                if (this.IncludeCommonFolders != null) hashCode = hashCode * 59 + this.IncludeCommonFolders.GetHashCode();
                return hashCode;
            }
        }
    }
}
