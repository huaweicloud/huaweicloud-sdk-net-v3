using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStoragePoolResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_pool", NullValueHandling = NullValueHandling.Ignore)]
        public StoragePool StoragePool { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStoragePoolResponse {\n");
            sb.Append("  storagePool: ").Append(StoragePool).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStoragePoolResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStoragePoolResponse input)
        {
            if (input == null) return false;
            if (this.StoragePool != input.StoragePool || (this.StoragePool != null && !this.StoragePool.Equals(input.StoragePool))) return false;

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
                if (this.StoragePool != null) hashCode = hashCode * 59 + this.StoragePool.GetHashCode();
                return hashCode;
            }
        }
    }
}
