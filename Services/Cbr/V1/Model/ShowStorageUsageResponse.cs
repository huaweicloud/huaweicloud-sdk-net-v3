using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStorageUsageResponse : SdkResponse
    {

        /// <summary>
        /// 满足过滤条件的资源总条数
        /// </summary>
        [JsonProperty("resource_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_usage", NullValueHandling = NullValueHandling.Ignore)]
        public List<StorageUsage> StorageUsage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStorageUsageResponse {\n");
            sb.Append("  resourceCount: ").Append(ResourceCount).Append("\n");
            sb.Append("  storageUsage: ").Append(StorageUsage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStorageUsageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStorageUsageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceCount == input.ResourceCount ||
                    (this.ResourceCount != null &&
                    this.ResourceCount.Equals(input.ResourceCount))
                ) && 
                (
                    this.StorageUsage == input.StorageUsage ||
                    this.StorageUsage != null &&
                    input.StorageUsage != null &&
                    this.StorageUsage.SequenceEqual(input.StorageUsage)
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
                if (this.ResourceCount != null)
                    hashCode = hashCode * 59 + this.ResourceCount.GetHashCode();
                if (this.StorageUsage != null)
                    hashCode = hashCode * 59 + this.StorageUsage.GetHashCode();
                return hashCode;
            }
        }
    }
}
