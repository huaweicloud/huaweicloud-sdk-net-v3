using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 变更云硬盘类型
    /// </summary>
    public class RetypeVolume 
    {

        /// <summary>
        /// 变更至指定的云硬盘类型
        /// </summary>
        [JsonProperty("new_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NewType { get; set; }

        /// <summary>
        /// 云硬盘iops大小。
        /// </summary>
        [JsonProperty("iops", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iops { get; set; }

        /// <summary>
        /// 云硬盘的吞吐量大小。
        /// </summary>
        [JsonProperty("throughput", NullValueHandling = NullValueHandling.Ignore)]
        public int? Throughput { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetypeVolume {\n");
            sb.Append("  newType: ").Append(NewType).Append("\n");
            sb.Append("  iops: ").Append(Iops).Append("\n");
            sb.Append("  throughput: ").Append(Throughput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetypeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetypeVolume input)
        {
            if (input == null) return false;
            if (this.NewType != input.NewType || (this.NewType != null && !this.NewType.Equals(input.NewType))) return false;
            if (this.Iops != input.Iops || (this.Iops != null && !this.Iops.Equals(input.Iops))) return false;
            if (this.Throughput != input.Throughput || (this.Throughput != null && !this.Throughput.Equals(input.Throughput))) return false;

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
                if (this.NewType != null) hashCode = hashCode * 59 + this.NewType.GetHashCode();
                if (this.Iops != null) hashCode = hashCode * 59 + this.Iops.GetHashCode();
                if (this.Throughput != null) hashCode = hashCode * 59 + this.Throughput.GetHashCode();
                return hashCode;
            }
        }
    }
}
