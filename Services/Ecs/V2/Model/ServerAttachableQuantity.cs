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
    /// 云服务器可挂载网卡和卷数。
    /// </summary>
    public class ServerAttachableQuantity 
    {

        /// <summary>
        /// 可挂载scsi卷数。
        /// </summary>
        [JsonProperty("free_scsi", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeScsi { get; set; }

        /// <summary>
        /// 可挂载vbd卷数。
        /// </summary>
        [JsonProperty("free_blk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeBlk { get; set; }

        /// <summary>
        /// 可挂载卷数。
        /// </summary>
        [JsonProperty("free_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeDisk { get; set; }

        /// <summary>
        /// 可挂载网卡数。
        /// </summary>
        [JsonProperty("free_nic", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeNic { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerAttachableQuantity {\n");
            sb.Append("  freeScsi: ").Append(FreeScsi).Append("\n");
            sb.Append("  freeBlk: ").Append(FreeBlk).Append("\n");
            sb.Append("  freeDisk: ").Append(FreeDisk).Append("\n");
            sb.Append("  freeNic: ").Append(FreeNic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerAttachableQuantity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerAttachableQuantity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FreeScsi == input.FreeScsi ||
                    (this.FreeScsi != null &&
                    this.FreeScsi.Equals(input.FreeScsi))
                ) && 
                (
                    this.FreeBlk == input.FreeBlk ||
                    (this.FreeBlk != null &&
                    this.FreeBlk.Equals(input.FreeBlk))
                ) && 
                (
                    this.FreeDisk == input.FreeDisk ||
                    (this.FreeDisk != null &&
                    this.FreeDisk.Equals(input.FreeDisk))
                ) && 
                (
                    this.FreeNic == input.FreeNic ||
                    (this.FreeNic != null &&
                    this.FreeNic.Equals(input.FreeNic))
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
                if (this.FreeScsi != null)
                    hashCode = hashCode * 59 + this.FreeScsi.GetHashCode();
                if (this.FreeBlk != null)
                    hashCode = hashCode * 59 + this.FreeBlk.GetHashCode();
                if (this.FreeDisk != null)
                    hashCode = hashCode * 59 + this.FreeDisk.GetHashCode();
                if (this.FreeNic != null)
                    hashCode = hashCode * 59 + this.FreeNic.GetHashCode();
                return hashCode;
            }
        }
    }
}
