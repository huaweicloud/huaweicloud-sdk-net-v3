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
    /// 存储定义元数据。
    /// </summary>
    public class Storage 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  storageHandle: ").Append(StorageHandle).Append("\n");
            sb.Append("  storageClass: ").Append(StorageClass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Storage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Storage input)
        {
            if (input == null) return false;
            if (this.StorageHandle != input.StorageHandle || (this.StorageHandle != null && !this.StorageHandle.Equals(input.StorageHandle))) return false;
            if (this.StorageClass != input.StorageClass || (this.StorageClass != null && !this.StorageClass.Equals(input.StorageClass))) return false;

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
                return hashCode;
            }
        }
    }
}
