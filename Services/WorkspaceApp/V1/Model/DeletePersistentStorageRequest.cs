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
    /// Request Object
    /// </summary>
    public class DeletePersistentStorageRequest 
    {

        /// <summary>
        /// WKS存储ID。
        /// </summary>
        [SDKProperty("storage_id", IsPath = true)]
        [JsonProperty("storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePersistentStorageRequest {\n");
            sb.Append("  storageId: ").Append(StorageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePersistentStorageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePersistentStorageRequest input)
        {
            if (input == null) return false;
            if (this.StorageId != input.StorageId || (this.StorageId != null && !this.StorageId.Equals(input.StorageId))) return false;

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
                if (this.StorageId != null) hashCode = hashCode * 59 + this.StorageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
