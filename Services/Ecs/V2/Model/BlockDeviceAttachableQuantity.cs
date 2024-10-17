using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 云服务器可挂载磁盘数量。
    /// </summary>
    public class BlockDeviceAttachableQuantity 
    {

        /// <summary>
        /// 云服务器可挂载scsi类型磁盘数量。
        /// </summary>
        [JsonProperty("free_scsi", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeScsi { get; set; }

        /// <summary>
        /// 云服务器可挂载virtio_blk类型磁盘数量。
        /// </summary>
        [JsonProperty("free_blk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeBlk { get; set; }

        /// <summary>
        /// 云服务器可挂载磁盘总数。
        /// </summary>
        [JsonProperty("free_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeDisk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockDeviceAttachableQuantity {\n");
            sb.Append("  freeScsi: ").Append(FreeScsi).Append("\n");
            sb.Append("  freeBlk: ").Append(FreeBlk).Append("\n");
            sb.Append("  freeDisk: ").Append(FreeDisk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlockDeviceAttachableQuantity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BlockDeviceAttachableQuantity input)
        {
            if (input == null) return false;
            if (this.FreeScsi != input.FreeScsi || (this.FreeScsi != null && !this.FreeScsi.Equals(input.FreeScsi))) return false;
            if (this.FreeBlk != input.FreeBlk || (this.FreeBlk != null && !this.FreeBlk.Equals(input.FreeBlk))) return false;
            if (this.FreeDisk != input.FreeDisk || (this.FreeDisk != null && !this.FreeDisk.Equals(input.FreeDisk))) return false;

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
                if (this.FreeScsi != null) hashCode = hashCode * 59 + this.FreeScsi.GetHashCode();
                if (this.FreeBlk != null) hashCode = hashCode * 59 + this.FreeBlk.GetHashCode();
                if (this.FreeDisk != null) hashCode = hashCode * 59 + this.FreeDisk.GetHashCode();
                return hashCode;
            }
        }
    }
}
