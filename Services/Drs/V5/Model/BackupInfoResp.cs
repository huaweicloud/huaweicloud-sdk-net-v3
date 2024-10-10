using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 备份文件信息
    /// </summary>
    public class BackupInfoResp 
    {

        /// <summary>
        /// 备份文件来源，包括OBS和RDS两种。
        /// </summary>
        [JsonProperty("file_source", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSource { get; set; }

        /// <summary>
        /// OBS桶名称。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 备份文件列表。
        /// </summary>
        [JsonProperty("file_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupFileResp> FileInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupInfoResp {\n");
            sb.Append("  fileSource: ").Append(FileSource).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  fileInfo: ").Append(FileInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupInfoResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileSource == input.FileSource ||
                    (this.FileSource != null &&
                    this.FileSource.Equals(input.FileSource))
                ) && 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.FileInfo == input.FileInfo ||
                    this.FileInfo != null &&
                    input.FileInfo != null &&
                    this.FileInfo.SequenceEqual(input.FileInfo)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FileSource != null)
                    hashCode = hashCode * 59 + this.FileSource.GetHashCode();
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.FileInfo != null)
                    hashCode = hashCode * 59 + this.FileInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
