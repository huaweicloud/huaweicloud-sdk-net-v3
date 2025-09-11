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
    /// 
    /// </summary>
    public class AttachableQuantityForNic 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_efi_nic", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeEfiNic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_scsi", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeScsi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_blk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeBlk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeDisk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_nic", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeNic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachableQuantityForNic {\n");
            sb.Append("  freeEfiNic: ").Append(FreeEfiNic).Append("\n");
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
            return this.Equals(input as AttachableQuantityForNic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachableQuantityForNic input)
        {
            if (input == null) return false;
            if (this.FreeEfiNic != input.FreeEfiNic || (this.FreeEfiNic != null && !this.FreeEfiNic.Equals(input.FreeEfiNic))) return false;
            if (this.FreeScsi != input.FreeScsi || (this.FreeScsi != null && !this.FreeScsi.Equals(input.FreeScsi))) return false;
            if (this.FreeBlk != input.FreeBlk || (this.FreeBlk != null && !this.FreeBlk.Equals(input.FreeBlk))) return false;
            if (this.FreeDisk != input.FreeDisk || (this.FreeDisk != null && !this.FreeDisk.Equals(input.FreeDisk))) return false;
            if (this.FreeNic != input.FreeNic || (this.FreeNic != null && !this.FreeNic.Equals(input.FreeNic))) return false;

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
                if (this.FreeEfiNic != null) hashCode = hashCode * 59 + this.FreeEfiNic.GetHashCode();
                if (this.FreeScsi != null) hashCode = hashCode * 59 + this.FreeScsi.GetHashCode();
                if (this.FreeBlk != null) hashCode = hashCode * 59 + this.FreeBlk.GetHashCode();
                if (this.FreeDisk != null) hashCode = hashCode * 59 + this.FreeDisk.GetHashCode();
                if (this.FreeNic != null) hashCode = hashCode * 59 + this.FreeNic.GetHashCode();
                return hashCode;
            }
        }
    }
}
