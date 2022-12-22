using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStorageTypeResponse : SdkResponse
    {

        /// <summary>
        /// 实例磁盘类型信息。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<Storage> StorageType { get; set; }

        /// <summary>
        /// 实例专属存储信息。
        /// </summary>
        [JsonProperty("dss_pool_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DssPoolInfo> DssPoolInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStorageTypeResponse {\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  dssPoolInfo: ").Append(DssPoolInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStorageTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStorageTypeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageType == input.StorageType ||
                    this.StorageType != null &&
                    input.StorageType != null &&
                    this.StorageType.SequenceEqual(input.StorageType)
                ) && 
                (
                    this.DssPoolInfo == input.DssPoolInfo ||
                    this.DssPoolInfo != null &&
                    input.DssPoolInfo != null &&
                    this.DssPoolInfo.SequenceEqual(input.DssPoolInfo)
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
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.DssPoolInfo != null)
                    hashCode = hashCode * 59 + this.DssPoolInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
