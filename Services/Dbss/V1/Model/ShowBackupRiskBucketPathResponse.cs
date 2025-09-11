using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBackupRiskBucketPathResponse : SdkResponse
    {

        /// <summary>
        /// 账户ID
        /// </summary>
        [JsonProperty("backup_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupDomainId { get; set; }

        /// <summary>
        /// OBS桶名称
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// OBS桶根路径
        /// </summary>
        [JsonProperty("bucket_root_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketRootPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupRiskBucketPathResponse {\n");
            sb.Append("  backupDomainId: ").Append(BackupDomainId).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  bucketRootPath: ").Append(BucketRootPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupRiskBucketPathResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupRiskBucketPathResponse input)
        {
            if (input == null) return false;
            if (this.BackupDomainId != input.BackupDomainId || (this.BackupDomainId != null && !this.BackupDomainId.Equals(input.BackupDomainId))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.BucketRootPath != input.BucketRootPath || (this.BucketRootPath != null && !this.BucketRootPath.Equals(input.BucketRootPath))) return false;

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
                if (this.BackupDomainId != null) hashCode = hashCode * 59 + this.BackupDomainId.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.BucketRootPath != null) hashCode = hashCode * 59 + this.BucketRootPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
