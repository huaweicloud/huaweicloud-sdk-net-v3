using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HtapStorageTypeStorageType 
    {

        /// <summary>
        /// 存储介质名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可支持可用区信息。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzStatus { get; set; }

        /// <summary>
        /// 最小可提供磁盘大小。
        /// </summary>
        [JsonProperty("min_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVolumeSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtapStorageTypeStorageType {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("  minVolumeSize: ").Append(MinVolumeSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HtapStorageTypeStorageType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HtapStorageTypeStorageType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AzStatus == input.AzStatus ||
                    this.AzStatus != null &&
                    input.AzStatus != null &&
                    this.AzStatus.SequenceEqual(input.AzStatus)
                ) && 
                (
                    this.MinVolumeSize == input.MinVolumeSize ||
                    (this.MinVolumeSize != null &&
                    this.MinVolumeSize.Equals(input.MinVolumeSize))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AzStatus != null)
                    hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                if (this.MinVolumeSize != null)
                    hashCode = hashCode * 59 + this.MinVolumeSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
