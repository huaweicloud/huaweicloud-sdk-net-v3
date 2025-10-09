using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AuthorizeBackupDownloadResponse : SdkResponse
    {

        /// <summary>
        /// OBS桶名。
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 通过OBS Browser+下载备份文件的路径名称。
        /// </summary>
        [JsonProperty("file_paths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FilePaths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeBackupDownloadResponse {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  filePaths: ").Append(FilePaths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizeBackupDownloadResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizeBackupDownloadResponse input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.FilePaths != input.FilePaths || (this.FilePaths != null && input.FilePaths != null && !this.FilePaths.SequenceEqual(input.FilePaths))) return false;

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
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.FilePaths != null) hashCode = hashCode * 59 + this.FilePaths.GetHashCode();
                return hashCode;
            }
        }
    }
}
