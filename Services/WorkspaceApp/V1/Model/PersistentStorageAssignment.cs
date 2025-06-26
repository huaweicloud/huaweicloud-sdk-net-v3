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
    /// 存储声明关联作用对象。
    /// </summary>
    public class PersistentStorageAssignment 
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
        public ClaimMode ClaimMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public StorageMetadata StorageMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_statement", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyStatement PolicyStatement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public Attachment Attachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersistentStorageAssignment {\n");
            sb.Append("  storageClaimId: ").Append(StorageClaimId).Append("\n");
            sb.Append("  folderPath: ").Append(FolderPath).Append("\n");
            sb.Append("  delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  claimMode: ").Append(ClaimMode).Append("\n");
            sb.Append("  storageMetadata: ").Append(StorageMetadata).Append("\n");
            sb.Append("  policyStatement: ").Append(PolicyStatement).Append("\n");
            sb.Append("  attachment: ").Append(Attachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PersistentStorageAssignment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PersistentStorageAssignment input)
        {
            if (input == null) return false;
            if (this.StorageClaimId != input.StorageClaimId || (this.StorageClaimId != null && !this.StorageClaimId.Equals(input.StorageClaimId))) return false;
            if (this.FolderPath != input.FolderPath || (this.FolderPath != null && !this.FolderPath.Equals(input.FolderPath))) return false;
            if (this.Delimiter != input.Delimiter || (this.Delimiter != null && !this.Delimiter.Equals(input.Delimiter))) return false;
            if (this.ClaimMode != input.ClaimMode) return false;
            if (this.StorageMetadata != input.StorageMetadata || (this.StorageMetadata != null && !this.StorageMetadata.Equals(input.StorageMetadata))) return false;
            if (this.PolicyStatement != input.PolicyStatement || (this.PolicyStatement != null && !this.PolicyStatement.Equals(input.PolicyStatement))) return false;
            if (this.Attachment != input.Attachment || (this.Attachment != null && !this.Attachment.Equals(input.Attachment))) return false;

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
                hashCode = hashCode * 59 + this.ClaimMode.GetHashCode();
                if (this.StorageMetadata != null) hashCode = hashCode * 59 + this.StorageMetadata.GetHashCode();
                if (this.PolicyStatement != null) hashCode = hashCode * 59 + this.PolicyStatement.GetHashCode();
                if (this.Attachment != null) hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
