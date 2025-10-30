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
    /// 存储单元
    /// </summary>
    public class StorageUnit 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public StorageType StorageType { get; set; }
        /// <summary>
        /// 存储池大小，单位：TB。
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Capacity { get; set; }

        /// <summary>
        /// 存储池销售档位
        /// </summary>
        [JsonProperty("gears", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Gears { get; set; }

        /// <summary>
        /// 规格类型。例如：highio-4T
        /// </summary>
        [JsonProperty("flavor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorType { get; set; }

        /// <summary>
        /// 存储节点台数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageUnit {\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  gears: ").Append(Gears).Append("\n");
            sb.Append("  flavorType: ").Append(FlavorType).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageUnit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageUnit input)
        {
            if (input == null) return false;
            if (this.StorageType != input.StorageType) return false;
            if (this.Capacity != input.Capacity || (this.Capacity != null && !this.Capacity.Equals(input.Capacity))) return false;
            if (this.Gears != input.Gears || (this.Gears != null && input.Gears != null && !this.Gears.SequenceEqual(input.Gears))) return false;
            if (this.FlavorType != input.FlavorType || (this.FlavorType != null && !this.FlavorType.Equals(input.FlavorType))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.Capacity != null) hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Gears != null) hashCode = hashCode * 59 + this.Gears.GetHashCode();
                if (this.FlavorType != null) hashCode = hashCode * 59 + this.FlavorType.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
