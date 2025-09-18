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
    /// 基于WKS存储创建的，文件夹存储声明。
    /// </summary>
    public class PersistentStorageClaim 
    {

        /// <summary>
        /// WKS存储目录声明ID。
        /// </summary>
        [JsonProperty("storage_claim_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClaimId { get; set; }

        /// <summary>
        /// 存储对象路径。 注: path是对象在系统中的完整路径。 例如系统中存在如下目录结构的数据。 SFS-Tmp: └─shares   ├─image   └─video image的路径: shares/image/ video的路径: shares/video/
        /// </summary>
        [JsonProperty("folder_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderPath { get; set; }

        /// <summary>
        /// 路径分隔符。
        /// </summary>
        [JsonProperty("delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string Delimiter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("claim_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ClaimMode? ClaimMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersistentStorageClaim {\n");
            sb.Append("  storageClaimId: ").Append(StorageClaimId).Append("\n");
            sb.Append("  folderPath: ").Append(FolderPath).Append("\n");
            sb.Append("  delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  claimMode: ").Append(ClaimMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PersistentStorageClaim);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PersistentStorageClaim input)
        {
            if (input == null) return false;
            if (this.StorageClaimId != input.StorageClaimId || (this.StorageClaimId != null && !this.StorageClaimId.Equals(input.StorageClaimId))) return false;
            if (this.FolderPath != input.FolderPath || (this.FolderPath != null && !this.FolderPath.Equals(input.FolderPath))) return false;
            if (this.Delimiter != input.Delimiter || (this.Delimiter != null && !this.Delimiter.Equals(input.Delimiter))) return false;
            if (this.ClaimMode != input.ClaimMode || (this.ClaimMode != null && !this.ClaimMode.Equals(input.ClaimMode))) return false;

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
                if (this.StorageClaimId != null) hashCode = hashCode * 59 + this.StorageClaimId.GetHashCode();
                if (this.FolderPath != null) hashCode = hashCode * 59 + this.FolderPath.GetHashCode();
                if (this.Delimiter != null) hashCode = hashCode * 59 + this.Delimiter.GetHashCode();
                if (this.ClaimMode != null) hashCode = hashCode * 59 + this.ClaimMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
