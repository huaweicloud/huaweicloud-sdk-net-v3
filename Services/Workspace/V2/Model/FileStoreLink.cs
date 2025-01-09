using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 文件存储路径支持OBS或者外部链接，store_type指定实际生效的配置,bucket_store和file_link必须设置其一。
    /// </summary>
    public class FileStoreLink 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("store_type", NullValueHandling = NullValueHandling.Ignore)]
        public FileStoreTypeEnum StoreType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bucket_store", NullValueHandling = NullValueHandling.Ignore)]
        public BucketStore BucketStore { get; set; }

        /// <summary>
        /// 文件下载完整路径。
        /// </summary>
        [JsonProperty("file_link", NullValueHandling = NullValueHandling.Ignore)]
        public string FileLink { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileStoreLink {\n");
            sb.Append("  storeType: ").Append(StoreType).Append("\n");
            sb.Append("  bucketStore: ").Append(BucketStore).Append("\n");
            sb.Append("  fileLink: ").Append(FileLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileStoreLink);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileStoreLink input)
        {
            if (input == null) return false;
            if (this.StoreType != input.StoreType) return false;
            if (this.BucketStore != input.BucketStore || (this.BucketStore != null && !this.BucketStore.Equals(input.BucketStore))) return false;
            if (this.FileLink != input.FileLink || (this.FileLink != null && !this.FileLink.Equals(input.FileLink))) return false;

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
                hashCode = hashCode * 59 + this.StoreType.GetHashCode();
                if (this.BucketStore != null) hashCode = hashCode * 59 + this.BucketStore.GetHashCode();
                if (this.FileLink != null) hashCode = hashCode * 59 + this.FileLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
