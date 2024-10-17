using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VodSampleData 
    {

        /// <summary>
        /// 存储空间。  单位：GB。
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public float? Storage { get; set; }

        /// <summary>
        /// 低频存储空间。  单位：GB。
        /// </summary>
        [JsonProperty("storage_warm", NullValueHandling = NullValueHandling.Ignore)]
        public float? StorageWarm { get; set; }

        /// <summary>
        /// 归档存储空间。  单位：GB。
        /// </summary>
        [JsonProperty("storage_cold", NullValueHandling = NullValueHandling.Ignore)]
        public float? StorageCold { get; set; }

        /// <summary>
        /// 转码时长。  单位：分钟。
        /// </summary>
        [JsonProperty("transcode", NullValueHandling = NullValueHandling.Ignore)]
        public long? Transcode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VodSampleData {\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  storageWarm: ").Append(StorageWarm).Append("\n");
            sb.Append("  storageCold: ").Append(StorageCold).Append("\n");
            sb.Append("  transcode: ").Append(Transcode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VodSampleData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VodSampleData input)
        {
            if (input == null) return false;
            if (this.Storage != input.Storage || (this.Storage != null && !this.Storage.Equals(input.Storage))) return false;
            if (this.StorageWarm != input.StorageWarm || (this.StorageWarm != null && !this.StorageWarm.Equals(input.StorageWarm))) return false;
            if (this.StorageCold != input.StorageCold || (this.StorageCold != null && !this.StorageCold.Equals(input.StorageCold))) return false;
            if (this.Transcode != input.Transcode || (this.Transcode != null && !this.Transcode.Equals(input.Transcode))) return false;

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
                if (this.Storage != null) hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.StorageWarm != null) hashCode = hashCode * 59 + this.StorageWarm.GetHashCode();
                if (this.StorageCold != null) hashCode = hashCode * 59 + this.StorageCold.GetHashCode();
                if (this.Transcode != null) hashCode = hashCode * 59 + this.Transcode.GetHashCode();
                return hashCode;
            }
        }
    }
}
