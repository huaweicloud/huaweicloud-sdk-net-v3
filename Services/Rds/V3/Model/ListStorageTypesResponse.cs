using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStorageTypesResponse : SdkResponse
    {

        /// <summary>
        /// 实例磁盘类型信息。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<Storage> StorageType { get; set; }

        /// <summary>
        /// 实例专属存储信息。
        /// </summary>
        [JsonProperty("dsspool_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DssPoolInfo> DsspoolInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStorageTypesResponse {\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  dsspoolInfo: ").Append(DsspoolInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStorageTypesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStorageTypesResponse input)
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
                    this.DsspoolInfo == input.DsspoolInfo ||
                    this.DsspoolInfo != null &&
                    input.DsspoolInfo != null &&
                    this.DsspoolInfo.SequenceEqual(input.DsspoolInfo)
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
                if (this.DsspoolInfo != null)
                    hashCode = hashCode * 59 + this.DsspoolInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
