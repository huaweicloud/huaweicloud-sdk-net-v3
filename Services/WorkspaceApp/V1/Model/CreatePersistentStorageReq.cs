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
    /// 创建WKS存储。
    /// </summary>
    public class CreatePersistentStorageReq 
    {

        /// <summary>
        /// WKS存储名称,名称需满足如下规则: 1. 名称允许可见字符或空格，不可为全空格。 2. 长度1~128个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Storage StorageMetadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePersistentStorageReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  storageMetadata: ").Append(StorageMetadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePersistentStorageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePersistentStorageReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.StorageMetadata != input.StorageMetadata || (this.StorageMetadata != null && !this.StorageMetadata.Equals(input.StorageMetadata))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StorageMetadata != null) hashCode = hashCode * 59 + this.StorageMetadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
