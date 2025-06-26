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
    /// 存储定义。
    /// </summary>
    public class StorageMetadata 
    {

        /// <summary>
        /// SFS文件系统名称。
        /// </summary>
        [JsonProperty("storage_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageHandle { get; set; }

        /// <summary>
        /// 存储类型： * &#x60;sfs&#x60; - sfs3.0存储。
        /// </summary>
        [JsonProperty("storage_class", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClass { get; set; }

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 所在区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 访问地址:protocol://[bucket-name].sfs3.[region-name].myhuaweicloud.com:port。
        /// </summary>
        [JsonProperty("export_location", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageMetadata {\n");
            sb.Append("  storageHandle: ").Append(StorageHandle).Append("\n");
            sb.Append("  storageClass: ").Append(StorageClass).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  exportLocation: ").Append(ExportLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageMetadata input)
        {
            if (input == null) return false;
            if (this.StorageHandle != input.StorageHandle || (this.StorageHandle != null && !this.StorageHandle.Equals(input.StorageHandle))) return false;
            if (this.StorageClass != input.StorageClass || (this.StorageClass != null && !this.StorageClass.Equals(input.StorageClass))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ExportLocation != input.ExportLocation || (this.ExportLocation != null && !this.ExportLocation.Equals(input.ExportLocation))) return false;

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
                if (this.StorageHandle != null) hashCode = hashCode * 59 + this.StorageHandle.GetHashCode();
                if (this.StorageClass != null) hashCode = hashCode * 59 + this.StorageClass.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ExportLocation != null) hashCode = hashCode * 59 + this.ExportLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
